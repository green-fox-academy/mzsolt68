using Microsoft.EntityFrameworkCore;
using RESTApiTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTApiTest.Repository
{
    public class LogDbContext : DbContext
    {
        public DbSet<Log> Logs { get; set; }

        public LogDbContext(DbContextOptions<LogDbContext> options) : base(options)
        {

        }
    }
}
