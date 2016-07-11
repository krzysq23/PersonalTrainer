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

        async void SaveClicked(object sender, EventArgs e)
        {
            _user.UserName = userNameEntry.Text;
            _user.Age = Convert.ToInt32(ageEntry.Text);
            _user.Weight = Convert.ToInt32(weightEntry.Text);
            _user.Height = Convert.ToInt32(heightEntry.Text);
            try
            {
                App.UserManager.SaveUser(_user);
                await DisplayAlert(AppResource.Info, AppResource.SaveChanges, "OK");
            }
            catch (Exception ex)
            {
                Acr.UserDialogs.UserDialogs.Instance.ShowError(ex.Message);
            }
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
            malePicker = AppResource.Male;
            famalePicker = AppResource.Male;
            save.Text = AppResource.Save;
        }
    }
}
