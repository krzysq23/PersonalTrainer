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
    public class TrainingCalendarViewModel : AppViewModelBase
    {
        private readonly INavigationService _navigationService;
        public TrainingCalendarViewModel(INavigationService navigationService)
        {
            if (navigationService == null) throw new ArgumentNullException("navigationService");
            _navigationService = navigationService;

            Title = AppResource.TrainingCalendar;
        }

    }
}
