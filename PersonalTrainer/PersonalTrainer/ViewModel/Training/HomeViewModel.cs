using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using PersonalTrainer.Resx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PersonalTrainer.ViewModel
{
    public class HomeViewModel : AppViewModelBase
    {
        private readonly INavigationService _navigationService;
        public HomeViewModel(INavigationService navigationService)
        {
            if (navigationService == null) throw new ArgumentNullException("navigationService");
            _navigationService = navigationService;

            Title = AppResource.Home;

            UserEditInfoCommand = new RelayCommand(() => { _navigationService.NavigateTo(ViewModelLocator.UserEditInfoPage); });
            BmiCommand = new RelayCommand(() => { _navigationService.NavigateTo(ViewModelLocator.BMIPage); });
            AddTrainingCommand = new RelayCommand(() => { _navigationService.NavigateTo(ViewModelLocator.AddTrainingPage); });
            TrainingCallendarCommand = new RelayCommand(() => { _navigationService.NavigateTo(ViewModelLocator.TrainingCallendarPage); });
        }

        public ICommand UserEditInfoCommand { get; set; }
        public ICommand BmiCommand { get; set; }
        public ICommand AddTrainingCommand { get; set; }
        public ICommand TrainingCallendarCommand { get; set; }

    }
}
