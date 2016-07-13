using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
namespace PersonalTrainer.Pages
{
    public partial class TrainingCalendarPage : ContentPage
    {
        public TrainingCalendarPage()
        {
            InitializeComponent();
            BindingContext = App.Locator.TrainingCalendar;
        }
    }
}

