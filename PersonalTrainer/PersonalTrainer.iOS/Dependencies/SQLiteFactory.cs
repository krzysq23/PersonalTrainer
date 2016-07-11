using System;
using System.Collections.Generic;
using System.Text;
using PersonalTrainer.Data;
using SQLite;
using System.IO;
using Xamarin.Forms;
using PersonalTrainer.WinPhone.Dependencies;

[assembly: Dependency(typeof(SQLiteFactory))]

namespace PersonalTrainer.WinPhone.Dependencies
{
    public class SQLiteFactory : ISQLiteFactory
    {
        public SQLiteFactory()
        {
        }

        public SQLite.SQLiteConnection GetConnection()
        {
            var sqliteFilename = "PTSQLite.db3";

            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
            var path = Path.Combine(documentsPath, sqliteFilename);

            var conn = new SQLiteConnection(path);

            return conn;
        }
    }
}