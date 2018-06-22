using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoTestEF
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Todos> todos = new List<Todos>();
            using (TodoEntities db = new TodoTestEF.TodoEntities())
            {
                todos = db.Todos.ToList();
            }
            todos.ForEach(
                todo => Console.WriteLine($"{todo.id} {todo.text} {todo.createdAt} {todo.completedAt}"));

            Console.ReadKey();
        }
    }
}
