using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.ViewModels
{
    public class UserListViewModel
    {
        internal IOrderedEnumerable<User> userListViewModel;

        public IEnumerable<User> Users { get; set; }
        public IEnumerable<Post> Posts { get; set; }
    }
}
