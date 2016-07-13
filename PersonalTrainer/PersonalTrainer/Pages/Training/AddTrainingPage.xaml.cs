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
    public partial class AddTrainingPage : ContentPage
    {
        List<string> SportTypeToEnum = new List<string>
        {
            { AppResource.Gym },
            { AppResource.Running },
            { AppResource.Cycling },
            { AppResource.Basketball },
            { AppResource.Football },
            { AppResource.Other }
        };

        public AddTrainingPage()
        {
            InitializeComponent();
            BindingContext = App.Locator.AddTraining;
            PickerItems();
            DataResource();
        }

        public void PickerItems()
        {
            foreach (string item in SportTypeToEnum)
            {
                typePicker.Items.Add(item);
            }
        }

        public void DataResource()
        {
            save.Text = AppResource.Save;
            dateLbl.Text = AppResource.DateStarded;
            timeLbl.Text = AppResource.DateStarded;
            lengthMinLbl.Text = AppResource.TrainingLengthMin;
            descriptionLbl.Text = AppResource.Description;
            lengthMinEntry.Placeholder = AppResource.TrainingLengthMin;
            descriptionEntry.Placeholder = AppResource.Description;
            typeLbl.Text = AppResource.SportType;
        }
    }
}
