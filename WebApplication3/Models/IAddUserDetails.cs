﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public interface IAddUserDetails
    {

        void AddUsers(User user);
        IEnumerable<User> GetUser { get; }
    }
}
