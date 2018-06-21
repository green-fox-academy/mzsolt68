using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace TODO
{
    class Program
    {
        static SQLiteConnection connection;
        static List<Todo> todos = new List<Todo>();
        static void Main(string[] args)
        {
            string databaseFile = "Todo.sqlite";
            connection = new SQLiteConnection("Data Source=Todo.sqlite; Version=3");
            if (!File.Exists(databaseFile))
                CreateDatabase(databaseFile);
            if (args.Length == 0)
            {
                PrintUsage();
                Environment.Exit(0);
            }
            LoadAll();
            switch (args[0])
            {
                case "-l": ListTodos();
                    break;
                case "-a": 
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
            foreach (var todo in todos)
            {
                Console.WriteLine($"{todo.id} -  {todo.text}");
            }
        }

        private static void Save(Todo todo)
        { }


        private static Todo Load(int id)
        {
            throw new NotImplementedException();
        }

        private static Todo Load(string text)
        {
            throw new NotImplementedException();
        }

        private static void LoadAll()
        {
            string commandtext = "SELECT * FROM Todos";
            using (connection)
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(commandtext, connection)) 
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Todo tmp = new Todo(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                                reader.GetDateTime(3), reader.GetDateTime(4));
                            todos.Add(tmp);
                        }
                    }
                }
                connection.Clone();
            }
        }

        private static void Delete()
        {
            throw new NotImplementedException();
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

        private static void CreateDatabase(string fileName)
        {
            SQLiteConnection.CreateFile(fileName);
            string createTable = "CREATE TABLE Todos(id INTEGER PRIMARY KEY AUTOINCREMENT, text VARCHAR NOT NULL, status VARCHAR NOT NULL, createdAt DATETIME NOT NULL, completedAt DATETIME)";
            using (connection)
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(createTable, connection))
                {
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}
