using CloneReddit.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloneReddit.Repositories
{
    public class RedditContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

        public RedditContext(DbContextOptions<RedditContext> options) : base(options)
        {

        }
    }
}
