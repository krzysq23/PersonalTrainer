using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using PersonalTrainer.Helper;
using PersonalTrainer.Pages;
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

        public App()
        {
            MainPage = new NavigationPage(new HomePage());
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
