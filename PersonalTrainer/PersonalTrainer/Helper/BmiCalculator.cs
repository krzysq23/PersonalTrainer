using PersonalTrainer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTrainer.Helper
{
    public class BmiCalculator : IBmiCalculator
    {
        public BmiCalculator()
        {

        }

        public int BmiWeight(User user)
        {
            return user.Height;
        }
    }
}
