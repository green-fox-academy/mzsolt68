using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoMVC.Models;

namespace TodoMVC.Services
{
    public class TodoWithList : TodoRepo
    {
        private List<Todo> taskList;

        public TodoWithList()
        {
            taskList = new List<Todo>
            {
                new Todo{ID = 1, Text = "Feed the dog", Created = DateTime.Parse("2018-06-27")},
                new Todo{ID = 2, Text = "Clean the garage", Created = DateTime.Parse("2018-05-31"), Completed = DateTime.Parse("2018.06.25")}
            };
        }

        public override void AddTodo(Todo task)
        {
            throw new NotImplementedException();
        }

        public override void DeleteTodo(Todo task)
        {
            throw new NotImplementedException();
        }

        public override List<Todo> GetTodos()
        {
            return taskList;
        }
    }
}
