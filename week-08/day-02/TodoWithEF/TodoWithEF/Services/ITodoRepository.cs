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
        void AddTodo(Todo newTodo);
    }
}
