using PersonalTrainer.Models;
using PersonalTrainer.Resx;
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

        public Dictionary<string, string> BmiName(double bmi)
        {
            Dictionary<string, string> bmiName = new Dictionary<string, string>();

            if(bmi < 16)
            {
                bmiName.Add(AppResource.Bmi1, "#012c50");
            }
            else if(bmi < 17)
            {
                bmiName.Add(AppResource.Bmi1, "#11528a");
            }
            else if (bmi < 18.5)
            {
                bmiName.Add(AppResource.Bmi1, "#2378c0");
            }
            else if (bmi < 25)
            {
                bmiName.Add(AppResource.Bmi1, "#58950c");
            }
            else if (bmi < 30)
            {
                bmiName.Add(AppResource.Bmi1, "#e369");
            }
            else if (bmi < 35)
            {
                bmiName.Add(AppResource.Bmi1, "#d4430c");
            }
            else if (bmi < 40)
            {
                bmiName.Add(AppResource.Bmi1, "#9b3008");
            }
            else
            {
                bmiName.Add(AppResource.Bmi1, "#661c00");
            }
            return bmiName;
        }

        public int BmiWeight(User user)
        {
            int bmi = 0;
            bmi = (user.Weight) / ((user.Height / 100) ^ 2);
            return bmi;
        }
    }
}
