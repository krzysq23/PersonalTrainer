using PersonalTrainer.Resx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace PersonalTrainer.Pages
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            BindingContext = App.Locator.Home;
            DataResource();
        }

        public void DataResource()
        {
            title.Text = AppResource.PersonalTrener;
            UserInfoBtn.Text = AppResource.UserEditInfo;
            BmiBtn.Text = AppResource.BMIlbl;
            AddtraningBtn.Text = AppResource.AddTraining;
            TrainingCalendarBtn.Text = AppResource.TrainingCalendar;
        }
    }
}
