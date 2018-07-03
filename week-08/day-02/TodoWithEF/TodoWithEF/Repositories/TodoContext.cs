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
        public TodoContext()
        {
            Todos = new List<Todo>()
            {
                new Todo{Title = "Start the day", IsUrgent = false, IsDone =false},
                new Todo{Title = "Feed the dog", IsUrgent = false, IsDone =false},
                new Todo{Title = "Clean the garage", IsUrgent = false, IsDone =false}
            };
        }
        public List<Todo> Todos { get; set; }
    }
}
