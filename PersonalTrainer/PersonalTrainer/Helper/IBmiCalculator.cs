using PersonalTrainer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTrainer.Helper
{
    public interface IBmiCalculator
    {
        int BmiWeight(User user);
    }
}
