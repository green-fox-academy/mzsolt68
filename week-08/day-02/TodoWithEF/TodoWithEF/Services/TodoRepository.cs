using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoWithEF.Repositories;
using TodoWithEF.Models;

namespace TodoWithEF.Services
{
    public class TodoRepository
    {
        TodoContext todoContext;

        public TodoRepository(TodoContext context)
        {
            this.todoContext = context;
        }

        public List<Todo> ListAllTodo()
        {
            return todoContext.Todos.ToList();
        }
    }
}
