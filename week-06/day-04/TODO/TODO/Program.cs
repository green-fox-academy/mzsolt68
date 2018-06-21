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
        static void Main(string[] args)
        {
            string databaseFile = "Todo.sqlite";
            if(!File.Exists(databaseFile))
                CreateDatabase(databaseFile);
            SQLiteConnection conn = new SQLiteConnection(databaseFile);
            
        }

        static void CreateDatabase(string fileName)
        {
            SQLiteConnection.CreateFile(fileName);
            string createTable = "CREATE TABLE Todos(id INTEGER PRIMARY KEY AUTOINCREMENT, text VARCHAR, status VARCHAR, createdAt DATETIME, completedAt DATETIME)";
            SQLiteConnection conn = new SQLiteConnection("Data Source=Todo.sqlite; Version=3");
            conn.Open();
            SQLiteCommand command = new SQLiteCommand(createTable, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
