using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using PersonalTrainer.Helper;
using PersonalTrainer.Models;
using PersonalTrainer.Resx;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PersonalTrainer.ViewModel
{
    public class BMIViewModel : AppViewModelBase
    {
        private readonly INavigationService _navigationService;
        public BMIViewModel(INavigationService navigationService)
        {
            if (navigationService == null) throw new ArgumentNullException("navigationService");
            _navigationService = navigationService;

            Title = "BMI";
            Refresh();
        }

        #region BmiInfo
        private Bmi _bmiInfo = new Bmi();
        public Bmi BmiInfo
        {
            get { return _bmiInfo; }
            set
            {
                _bmiInfo = value;
                OnPropertyChanged("BmiInfo");
            }
        }
        #endregion
        #region Refresh()
        void Refresh()
        {
            ExecuteRefreshCommand();
        }

        Command refreshCommand;
        public Command RefreshCommand
        {
            get { return refreshCommand ?? (refreshCommand = new Command(async () => await ExecuteRefreshCommand())); }
        }

        async Task ExecuteRefreshCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                var user = App.UserManager.GetUsers();
                _bmiInfo.BmiWeight = new BmiCalculator(user);
                ProductItems.Clear();
                foreach (var todo in products)
                {
                    ProductItems.Add(todo);
                }
            }
            catch (Exception ex)
            {
                Acr.UserDialogs.UserDialogs.Instance.ShowError(ex.Message);
            }
            finally
            {
                IsBusy = false;
            }
        }
        #endregion
    }
}
