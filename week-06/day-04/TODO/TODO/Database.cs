using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace TODO
{
    class Database
    {
        SQLiteConnection connection;
        SQLiteCommand command;
        SQLiteDataReader reader;

        public Database(string database)
        {
            connection = new SQLiteConnection($"Data Source={database}, Version 3");
            if (!File.Exists(database))
            {
                SQLiteConnection.CreateFile(database);
                string createTable = "CREATE TABLE Todos(id INTEGER PRIMARY KEY AUTOINCREMENT, text VARCHAR NOT NULL, createdAt DATETIME NOT NULL, completedAt DATETIME)";
                using (connection)
                {
                    OpenConnection();
                    using (SQLiteCommand command = new SQLiteCommand(createTable, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    CloseConnection();
                }
            }
        }

        public void OpenConnection()
        {
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();
        }

        public void CloseConnection()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
                connection.Close();
        }

        public void AddNewTodo(Todo todo)
        {
            string commandText = "Insert INTO todos (text, createdAt, completedAt) VALUES(@text, @created, @completed)";
            OpenConnection();
            using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
            {
                command.Parameters.AddWithValue("text", todo.text);
                command.Parameters.AddWithValue("created", todo.createdAt);
                command.Parameters.AddWithValue("completed", todo.completedAt);
                command.ExecuteNonQuery();
                Console.WriteLine("Todo added");
            }
            CloseConnection();
        }

        public void ListAllTodos()
        {
            string cmdText = "SELECT * FROM todos";
            OpenConnection();
            using (command = new SQLiteCommand(cmdText, connection))
            {
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Todo todo = new Todo();
                        todo.id = reader.GetInt32(0);
                        todo.text = reader.GetString(1);
                        todo.createdAt = reader.GetDateTime(2);
                        todo.completedAt = reader.GetDateTime(3);
                        Console.WriteLine(todo.ToString());
                    }
                }
            }
            CloseConnection();
        }
    }
}
