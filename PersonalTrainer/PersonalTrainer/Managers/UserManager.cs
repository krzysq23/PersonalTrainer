using PersonalTrainer.Data;
using PersonalTrainer.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTrainer.Managers
{
    public sealed class UserManager
    {
        static object locker = new object();

        private SQLiteConnection _connection;

        public UserManager()
        {
            _connection = new PTDatabase().Connection();
        }

        public User GetUser()
        {
            lock (locker)
            {
                return (from i in _connection.Table<User>() select i).FirstOrDefault();
            }
        }

        public int SaveUser(User item)
        {
            lock (locker)
            {
                if (item.Id != 0)
                {
                    _connection.Update(item);
                    return item.Id;
                }
                else
                {
                    return _connection.Insert(item);
                }
            }
        }
    }
}
