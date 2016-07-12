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
    public sealed class TrainingManager
    {
        static object locker = new object();

        private SQLiteConnection _connection;

        public TrainingManager()
        {
            _connection = new PTDatabase().Connection();
        }

        public Training GetTraining(int id)
        {
            lock (locker)
            {
                return (from i in _connection.Table<Training>() select i).Where(w => w.Id == id).FirstOrDefault();
            }
        }

        public IEnumerable<Training> GetTrainings()
        {
            lock (locker)
            {
                return (from i in _connection.Table<Training>() select i).ToList();
            }
        }

        public int SaveTraining(Training item)
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
        public int DeleteTraining(int id)
        {
            lock (locker)
            {
                return _connection.Delete<Training>(id);
            }
        }
    }
}
