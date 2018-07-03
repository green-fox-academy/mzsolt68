using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoWithEF.Models;

namespace TodoWithEF.Repositories
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
            Todos = new List<Todo>()
            {
                new Todo{Title = "Start the day"},
                new Todo{Title = "Feed the dog"},
                new Todo{Title = "Clean the garage"}
            };
        }
        public List<Todo> Todos { get; set; }
    }
}
