﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Redditv2.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public List<Post> Posts { get; set; }
    }
}
