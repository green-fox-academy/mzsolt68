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
            LoadAll();
            switch (args[0])
            {
                case "-l":
                    ListTodos();
                    break;
                case "-a":
                    Add(args, db.connection);
                    break;
                case "-r":
                    break;
                case "-c":
                    break;
                case "-u":
                    break;
                default:
                    break;
            }
        }

        private static void ListTodos()
        {
            foreach (var todo in todoList)
            {
                Console.WriteLine(todo.ToString());
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

        private static void LoadAll()
        {
            string cmdText = "SELECT * FROM todos";
            db.OpenConnection();
            using (SQLiteCommand command = new SQLiteCommand(cmdText, db.connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Todo todo = new Todo();
                        todo.id = reader.GetInt32(0);
                        todo.text = reader.GetString(1);
                        todo.createdAt = reader.GetDateTime(2);
                        todo.completedAt = reader["completedAt"] == DBNull.Value ? (DateTime?)null : reader.GetDateTime(3);
                        todoList.Add(todo);
                    }
                }
            }
            db.CloseConnection();
        }

        private static void Delete()
        {
            //
        }

        private static void Add(string[] args, SQLiteConnection connection)
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
            Console.WriteLine(" -r\tRemoves a task");
            Console.WriteLine(" -c\tCompletes a task");
            Console.WriteLine(" -u [id] [description] Update task description");
        }

    }
}
