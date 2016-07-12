using PersonalTrainer.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PersonalTrainer.Data
{
    class PTDatabase
    {
        SQLiteConnection _connection;

        public PTDatabase()
        {
            _connection = DependencyService.Get<ISQLiteFactory>().GetConnection();
            _connection.CreateTable<User>();
            _connection.CreateTable<Training>();
        }

        public SQLiteConnection Connection()
        {
            return _connection;
        }
    }
}
