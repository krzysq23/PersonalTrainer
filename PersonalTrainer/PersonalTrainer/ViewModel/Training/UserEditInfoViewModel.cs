using GalaSoft.MvvmLight.Views;
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
    public class UserEditInfoViewModel : AppViewModelBase
    {
        private readonly INavigationService _navigationService;
        public UserEditInfoViewModel(INavigationService navigationService)
        {
            if (navigationService == null) throw new ArgumentNullException("navigationService");
            _navigationService = navigationService;
            UserInfo = App.UserManager.GetUser();
            Title = AppResource.UserEditInfo;
            SelectedGenderEnum = ((int)_userInfo.Gender) - 1;
        }

        #region UserInfo
        private User _userInfo = new User();
        public User UserInfo
        {
            get { return _userInfo; }
            set
            {
                _userInfo = value;
                OnPropertyChanged("UserInfo");
            }
        }
        #endregion

        public int SelectedGenderEnum { get; set; }

        #region Save
        ICommand saveItemCommand;
        public ICommand SaveItemCommand
        {
            get
            {
                return saveItemCommand ?? (saveItemCommand = new Command(async () => await ExecuteSaveItemCommand()));
            }
        }

        async Task ExecuteSaveItemCommand()
        {
            if (IsBusy)
                return;

            //TODO: Rebind
            if (_userInfo != null)
            {
                _userInfo.Gender = (Gender)(SelectedGenderEnum + 1);

            }

            IsBusy = true;

            try
            {
                //Acr.UserDialogs.UserDialogs.Instance.ShowLoading("Saving new item");

                App.UserManager.SaveUser(_userInfo);

                //Acr.UserDialogs.UserDialogs.Instance.ShowSuccess("Updated item", 1500);

                await App.Current.MainPage.DisplayAlert(AppResource.Info, AppResource.SaveChanges, "OK");

                MessagingCenter.Send<UserEditInfoViewModel>(this, "ItemsChanged");
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
