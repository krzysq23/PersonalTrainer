using PersonalTrainer.Models;
using PersonalTrainer.Resx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace PersonalTrainer.Pages
{
    public partial class UserEditInfoPage : ContentPage
    {
        private User _user = new User();

        public UserEditInfoPage()
        {
            InitializeComponent();
            BindingContext = App.Locator.UserEditInfo;
            DataResource();
        }

        public void DataResource()
        {
            userNameLbl.Text = AppResource.UserName;
            userNameEntry.Placeholder = AppResource.UserName;
            ageLbl.Text = AppResource.Age;
            weightLbl.Text = AppResource.Weight;
            heightLbl.Text = AppResource.Height;
            ageEntry.Placeholder = AppResource.Age;
            weightEntry.Placeholder = AppResource.Weight;
            heightEntry.Placeholder = AppResource.Height;
            genderLbl.Text = AppResource.Gender;
            malelbl.Text = AppResource.Male;
            famalelbl.Text = AppResource.Famale;
            save.Text = AppResource.Save;
        }
    }
}
