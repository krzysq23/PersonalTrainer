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
        }

        async void SeccondButtonClicked(object sender, EventArgs e)
        {
            var navigation = Application.Current.MainPage as NavigationPage;
            await navigation.PushAsync(new Pages.SecondPage());
        }

    }
}
