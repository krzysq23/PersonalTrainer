using PersonalTrainer.Data;
using PersonalTrainer.WinPhone.Dependencies;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Xamarin.Forms;

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

            string path = Path.Combine(ApplicationData.Current.LocalFolder.Path, sqliteFilename);

            var conn = new SQLite.SQLiteConnection(path);

            return conn;
        }
    }
}
