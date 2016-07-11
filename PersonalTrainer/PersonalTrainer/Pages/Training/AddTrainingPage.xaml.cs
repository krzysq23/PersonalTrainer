using PersonalTrainer.Resx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace PersonalTrainer.Pages
{
    public partial class AddTrainingPage : ContentPage
    {
        public AddTrainingPage()
        {
            InitializeComponent();
            BindingContext = App.Locator.AddTraining;
            DataResource();
        }

        public void DataResource()
        {

        }
    }
}
