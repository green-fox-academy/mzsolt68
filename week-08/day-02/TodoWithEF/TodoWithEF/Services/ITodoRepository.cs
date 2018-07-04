using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoWithEF.Models;

namespace TodoWithEF.Services
{
    public interface ITodoRepository
    {
        List<Todo> ListAllTodo();
        List<Todo> ListActiveTodos();
        void AddTodo(Todo newTodo);
        void DeleteTodo(int ID);
        void UpdateTodo(Todo updatedTodo);
        Todo GetTodo(int id);
    }
}
