using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public interface IAddPostData
    {
        void AddPosts(Post post);
        public IEnumerable<Post> GetAllPost();
        public IEnumerable<Post> GetPostById(int id);
        public Post DeletePost(int postId);
    }
}
