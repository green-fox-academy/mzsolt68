﻿using System;
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
        string commandText;
        Dictionary<string, object> queryParameters;

        public Database(string database)
        {
            connection = new SQLiteConnection($"Data Source={database}, Version 3");
            if (!File.Exists(database))
            {
                SQLiteConnection.CreateFile(database);
                commandText = "CREATE TABLE Todos(id INTEGER PRIMARY KEY AUTOINCREMENT, text VARCHAR NOT NULL, createdAt DATETIME NOT NULL, completedAt DATETIME)";
                using (connection)
                {
                    OpenConnection();
                    using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    CloseConnection();
                }
            }
            queryParameters = new Dictionary<string, object>();
        }

        private void OpenConnection()
        {
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();
        }

        private void CloseConnection()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
                connection.Close();
        }

        private bool IdIsValid(int id)
        {
            int tmp;
            commandText = "Select COUNT(1) FROM Todos WHERE id = @id";
            OpenConnection();
            using (command = new SQLiteCommand(commandText, connection))
            {
                command.Parameters.AddWithValue("@id", id);
                tmp = Convert.ToInt32(command.ExecuteScalar());
            }
            CloseConnection();
            return  (tmp == 1) ? true : false;
        }

        private void NonQueryCommand()
        {
            OpenConnection();
            using (command = new SQLiteCommand(commandText, connection))
            {
                foreach (KeyValuePair<string, object> param in queryParameters)
                {
                    command.Parameters.AddWithValue(param.Key, param.Value);
                }
                command.ExecuteNonQuery();
            }
            CloseConnection();
            queryParameters.Clear();
        }

        public void AddNewTodo(Todo todo)
        {
            commandText = "Insert INTO todos (text, createdAt, completedAt) VALUES(@text, @created, @completed)";
            queryParameters.Add("@text", todo.text);
            queryParameters.Add("@created", todo.createdAt);
            queryParameters.Add("@completed", todo.completedAt);
            NonQueryCommand();
            Console.WriteLine($"New task \"{todo.text}\" is added.");
        }

        internal void UpdateTodo(int id, string text)
        {
            if(IdIsValid(id))
            {
                commandText = "UPDATE Todos SET text = @text WHERE id = @id";
                queryParameters.Add("@id", id);
                queryParameters.Add("@text", text);
                NonQueryCommand();
                Console.WriteLine($"Task Nr. {id} description is updated.");
            }
            else
            {
                Console.WriteLine($"Task Nr. {id} is not in the database.");
            }
        }

        public void ListAllTodos()
        {
            commandText = "SELECT * FROM todos";
            OpenConnection();
            using (command = new SQLiteCommand(commandText, connection))
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

        public void CompleteTodo(int id)
        {
            if (IdIsValid(id))
            {
                commandText = "UPDATE Todos SET completedAt = @completed WHERE id = @id";
                queryParameters.Add("@id", id);
                queryParameters.Add("@completed", DateTime.Now);
                NonQueryCommand();
                Console.WriteLine($"Task Nr. {id} is completed");
            }
            else
            {
                Console.WriteLine($"Task Nr. {id} is not in the database.");
            }
        }

        public void DeleteTodo(int id)
        {
            if(IdIsValid(id))
            {
                commandText = "DELETE FROM Todos WHERE id = @id";
                queryParameters.Add("@id", id);
                NonQueryCommand();
                Console.WriteLine($"Task Nr. {id} is deleted.");
            }
            else
            {
                Console.WriteLine($"Task Nr. {id} is not in the database.");
            }
        }
    }
}
