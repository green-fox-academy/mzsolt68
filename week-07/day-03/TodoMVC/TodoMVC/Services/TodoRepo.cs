using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoMVC.Models;

namespace TodoMVC.Services
{
    public abstract class TodoRepo
    {
        public abstract List<Todo> GetTodos();
        public abstract void AddTodo(Todo task);
        public abstract void DeleteTodo(Todo task);
    }
}
