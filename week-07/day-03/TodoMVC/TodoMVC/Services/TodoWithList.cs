using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoMVC.Models;

namespace TodoMVC.Services
{
    public class TodoWithList : TodoRepo
    {
        private int count = 1;
        private List<Todo> taskList;

        public TodoWithList()
        {
            taskList = new List<Todo>();
            AddTodo(new Todo { Text = "Feed the dog", Created = DateTime.Parse("2018-06-27"), IsUrgent = true });
            AddTodo(new Todo { Text = "Clean the garage", Created = DateTime.Parse("2018-05-31"), Completed = DateTime.Parse("2018.06.25") });
        }

        public override void AddTodo(Todo task)
        {
            task.ID = count;
            taskList.Add(task);
            count++;
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
