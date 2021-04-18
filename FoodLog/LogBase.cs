using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.IO;

namespace FoodLog
{
    class LogBase
    {
        public SQLiteConnection myConnection;
        public LogBase()
        {
            myConnection = new SQLiteConnection("Data Source=Log.sqlite");
            if (!File.Exists("./Log.sqlite"))
            {
                SQLiteConnection.CreateFile("Log.sqlite");
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
