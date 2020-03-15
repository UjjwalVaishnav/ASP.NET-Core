using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace WebApplication3.Models
{
    public class AddUser:IAddUserDetails
    {
        private readonly AppDbContext db;
        
        public AddUser(AppDbContext db)
        {
            this.db = db;
        }
        public void AddUsers(User user)
        {
            db.user.Add(user);
            db.SaveChanges();
            
        }
        public IEnumerable<User> GetUser
        {
            get
            {
                return db.user;
            }
        }
    }
}
