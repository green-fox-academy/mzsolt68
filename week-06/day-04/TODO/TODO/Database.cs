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
        public SQLiteConnection connection;

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
    }
}
