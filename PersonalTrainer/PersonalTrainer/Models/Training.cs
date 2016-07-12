using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTrainer.Models
{
    public class Training
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public SportType Type { get; set; }
        public int LengthMin { get; set; }
        public DateTime DateStarded { get; set; }
        public string Description { get; set; }
    }
}
