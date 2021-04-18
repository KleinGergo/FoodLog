using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.IO;


namespace FoodLog
{
    class Database
    {
        public SQLiteConnection myConnection;
        public Database()
        {
            myConnection = new SQLiteConnection("Data Source=Foods.sqlite");
            if(!File.Exists("./Foods.sqlite"))
            {
                SQLiteConnection.CreateFile("Foods.sqlite");
            }
        }
        public void OpenConnection()
        {
            if (myConnection.State != System.Data.ConnectionState.Open)
                myConnection.Open();
        }

        public void CloseConnection()
        {
            if (myConnection.State != System.Data.ConnectionState.Closed)
                myConnection.Clone();
        }
    }
}
