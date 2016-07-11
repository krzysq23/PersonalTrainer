/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:PersonalTrainer"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace PersonalTrainer.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<HomeViewModel>();
            SimpleIoc.Default.Register<UserEditInfoViewModel>();
            SimpleIoc.Default.Register<AddTrainingViewModel>();
            SimpleIoc.Default.Register<BMIViewModel>();
            SimpleIoc.Default.Register<TrainingCallendarViewModel>();
        }

        public const string HomePage = "HomePage";
        public const string UserEditInfoPage = "UserEditInfoPage";
        public const string BMIPage = "BMIPage";
        public const string AddTrainingPage = "AddTrainingPage";
        public const string TrainingCallendarPage = "TrainingCallendarPage";

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public HomeViewModel Home
        {
            get
            {
                return ServiceLocator.Current.GetInstance<HomeViewModel>();
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public UserEditInfoViewModel UserEditInfo
        {
            get
            {
                return ServiceLocator.Current.GetInstance<UserEditInfoViewModel>();
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public BMIViewModel BMI
        {
            get
            {
                return ServiceLocator.Current.GetInstance<BMIViewModel>();
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public AddTrainingViewModel AddTraining
        {
            get
            {
                return ServiceLocator.Current.GetInstance<AddTrainingViewModel>();
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public TrainingCallendarViewModel TrainingCallendar
        {
            get
            {
                return ServiceLocator.Current.GetInstance<TrainingCallendarViewModel>();
            }
        }
        public static void Cleanup()
        {

        }
    }
}