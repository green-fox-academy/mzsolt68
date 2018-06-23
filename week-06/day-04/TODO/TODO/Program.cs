using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.SQLite.EF6;
using System.IO;

namespace TODO
{
    class Program
    {
        static List<Todo> todoList = new List<Todo>();
        static Database db;
        static void Main(string[] args)
        {
            string databaseFile = "Todo.sqlite";
            if (args.Length == 0)
            {
                PrintUsage();
                Environment.Exit(0);
            }
            db = new Database(databaseFile);
            switch (args[0])
            {
                case "-l":
                    db.ListAllTodos();
                    break;
                case "-a":
                    Add(args);
                    break;
                case "-r":
                    break;
                case "-c":
                    Complete(args);
                    break;
                case "-u":
                    break;
                default:
                    break;
            }
        }

        private static void Complete(string[] args)
        {
            int id;

            if ((args.Length < 2) || (!int.TryParse(args[1], out id)))
            {
                Console.WriteLine("Missing or wrong id.");
            }
            else
            {
                db.CompleteTodo(id);
            }
        }

        private static void Save(Todo todo)
        {
            //
        }

        private static Todo Load(int id)
        {
            return null;
        }

        private static Todo Load(string text)
        {
            return null;
        }

        private static void Delete()
        {
            //
        }

        private static void Add(string[] args)
        {
            Todo todo = new Todo();
            DateTime tmp;
            switch (args.Length)
            {
                case 1: Console.WriteLine("Not enough parameter!");
                    break;
                case 2:
                    todo.text = args[1];
                    todo.createdAt = DateTime.Now;
                    break;
                case 3:
                    todo.text = args[1];
                    if (DateTime.TryParse(args[2], out tmp))
                    {
                        todo.createdAt = tmp;
                    }
                    else
                        Console.WriteLine("Wrong parameter!");
                    break;
                case 4:
                    todo.text = args[1];
                    if (DateTime.TryParse(args[2], out tmp))
                    {
                        todo.createdAt = tmp;
                    }
                    else
                        Console.WriteLine("Wrong parameter!");
                    if (DateTime.TryParse(args[3], out tmp))
                    {
                        todo.completedAt = tmp;
                    }
                    else
                        Console.WriteLine("Wrong parameter!");
                    break;
                default:
                    break;
            }
            db.AddNewTodo(todo);
        }

        private static void PrintUsage()
        {
            Console.WriteLine("Command Line TODO Application");
            Console.WriteLine("=============================");
            Console.WriteLine("\nCommand line arguments:");
            Console.WriteLine(" -l\tLists all the tasks");
            Console.WriteLine(" -a\tAdds a new task");
            Console.WriteLine(" -r [id]\tRemoves a task");
            Console.WriteLine(" -c [id]\tCompletes a task");
            Console.WriteLine(" -u [id] [description] Update task description");
        }

    }
}
