using PersonalTrainer.Resx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace PersonalTrainer.Pages
{
    public partial class BMIPage : ContentPage
    {
        public BMIPage()
        {
            InitializeComponent();
            BindingContext = App.Locator.BMI;
            DataResource();
        }

        public void DataResource()
        {
            bmilbl.Text = AppResource.UserName;
        }
    }
}
