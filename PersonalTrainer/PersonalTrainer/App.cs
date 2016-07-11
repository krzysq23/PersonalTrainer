using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using PersonalTrainer.Helper;
using PersonalTrainer.Managers;
using PersonalTrainer.Pages;
using PersonalTrainer.Resx;
using PersonalTrainer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PersonalTrainer
{
    public class App : Application
    {
        private static ViewModelLocator _locator;
        public static ViewModelLocator Locator { get { return _locator ?? (_locator = new ViewModelLocator()); } }
        private static UserManager _userManager;

        public App()
        {
            if (Device.OS != TargetPlatform.WinPhone)
            {
                DependencyService.Get<ILocalize>().SetLocale();
            }

            try
            {
               if(UserManager.GetUser() == null)
                {
                    UserManager.SaveUser(new Models.User());
                } 
            }
            catch(Exception ex)
            {
                Acr.UserDialogs.UserDialogs.Instance.ShowError(ex.Message);
            }

            NavigationService nav;

            if (!SimpleIoc.Default.IsRegistered<INavigationService>())
            {
                nav = new NavigationService();
                nav.Configure(ViewModelLocator.HomePage, typeof(HomePage));
                nav.Configure(ViewModelLocator.UserEditInfoPage, typeof(UserEditInfoPage));
                nav.Configure(ViewModelLocator.BMIPage, typeof(BMIPage));
                nav.Configure(ViewModelLocator.AddTrainingPage, typeof(AddTrainingPage));
                nav.Configure(ViewModelLocator.TrainingCallendarPage, typeof(TrainingCallendarPage));
                SimpleIoc.Default.Register<INavigationService>(() => nav);
            }
            else
            {
                nav = SimpleIoc.Default.GetInstance<NavigationService>();
            }

            var homePage = new NavigationPage(new HomePage());

            nav.Initialize(homePage);

            //SimpleIoc.Default.Register<INavigationService>(() => nav);

            MainPage = homePage;

        }

        public static UserManager UserManager
        {
            get
            {
                if (_userManager == null)
                {
                    _userManager = new UserManager();
                }
                return _userManager;
            }
        }

        protected override void OnStart()
        {

        }

        protected override void OnSleep()
        {

        }

        protected override void OnResume()
        {

        }
    }
}
