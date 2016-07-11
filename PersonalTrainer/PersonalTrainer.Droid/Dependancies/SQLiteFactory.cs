using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using PersonalTrainer.Data;
using SQLite;
using System.IO;
using PersonalTrainer.Droid.Dependancies;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteFactory))]

namespace PersonalTrainer.Droid.Dependancies
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