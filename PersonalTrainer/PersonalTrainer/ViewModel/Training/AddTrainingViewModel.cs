using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using PersonalTrainer.Models;
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
    public class AddTrainingViewModel : AppViewModelBase
    {
        private readonly INavigationService _navigationService;
        public AddTrainingViewModel(INavigationService navigationService)
        {
            if (navigationService == null) throw new ArgumentNullException("navigationService");
            _navigationService = navigationService;

            Training = new Training();

            SelectedIndexEnum = ((int)_training.Type);

            Title = AppResource.AddTraining;
        }

        #region Training
        private Training _training = new Training();
        public Training Training
        {
            get { return _training; }
            set
            {
                _training = value;
                OnPropertyChanged("Training");
            }
        }
        #endregion

        #region Properties
        public int SelectedIndexEnum { get; set; }
        #endregion

        #region Save
        Command saveItemCommand;
        public Command SaveItemCommand
        {
            get { return saveItemCommand ?? (saveItemCommand = new Command(async () => await ExecuteSaveItemCommand())); }
        }

        async Task ExecuteSaveItemCommand()
        {
            if (IsBusy)
                return;

            if (_training != null)
            {
                _training.Type = (SportType)(SelectedIndexEnum);
            }

            IsBusy = true;

            try
            {
                //Acr.UserDialogs.UserDialogs.Instance.ShowLoading("Saving new item");

                //App.TrainingManager.SaveTraining(_training);

                //Acr.UserDialogs.UserDialogs.Instance.ShowSuccess("Updated item", 1500);

                MessagingCenter.Send<AddTrainingViewModel>(this, "ItemsChanged");
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
