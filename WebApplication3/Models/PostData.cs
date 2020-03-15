using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.ViewModels;

namespace WebApplication3.Models
{
    public class PostData:IAddPostData
    {
        private readonly AppDbContext db;
        
        public PostData(AppDbContext db)
        {
            this.db = db;
        }
        public IEnumerable<Post> GetAllPost()
        {
            return from post in db.posts
                   select post;
        }

        public IEnumerable<Post> GetPostById(int id)
        {
            return from p in db.posts
                   where p.UserId.Equals(id)
                   select p;
        }
        public Post DeletePost(int postId)
        {
            var posts = db.posts.Find(postId);
            if (posts != null)
            {
                db.posts.Remove(posts);
            }
            return posts;
        }
        
        public void AddPosts(Post post)
        {
            db.posts.Add(post);
            //db.posts.Add();
            db.SaveChanges();
        }
    }
}
