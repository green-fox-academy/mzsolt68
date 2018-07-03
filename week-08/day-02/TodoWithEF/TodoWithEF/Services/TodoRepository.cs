using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoWithEF.Repositories;
using TodoWithEF.Models;

namespace TodoWithEF.Services
{
    public class TodoRepository : ITodoRepository
    {
        private TodoContext todoContext;

        public TodoRepository(TodoContext context)
        {
            todoContext = context;
        }

        public List<Todo> ListAllTodo()
        {
            return todoContext.Todos.ToList();
        }

        public void AddTodo(Todo newTodo)
        {
            todoContext.Add(newTodo);
            todoContext.SaveChanges();
        }
    }
}
