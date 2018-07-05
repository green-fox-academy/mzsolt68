using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoWithEF.Repositories;
using TodoWithEF.Models;
using Microsoft.EntityFrameworkCore;

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
            return todoContext.Todos.Include(t => t.Assignee).ToList();
        }

        public void AddTodo(Todo newTodo)
        {
            todoContext.Todos.Add(newTodo);
            todoContext.SaveChanges();
        }

        public List<Todo> ListActiveTodos()
        {
            return todoContext.Todos.Include(t => t.Assignee).Where(t => t.IsDone == false).ToList();
        }

        public void DeleteTodo(int ID)
        {
            todoContext.Todos.Remove(todoContext.Todos.Where(t => t.Id == ID).SingleOrDefault());
            todoContext.SaveChanges();
        }

        public void UpdateTodo(Todo updatedTodo)
        {
            todoContext.Todos.Update(updatedTodo);
            todoContext.SaveChanges();
        }

        public Todo GetTodo(int id)
        {
            return todoContext.Todos.Include(t => t.Assignee).Where(t => t.Id == id).SingleOrDefault();
        }
    }
}
