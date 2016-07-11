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
    public partial class MasterPage : ContentPage
    {
        public ListView ListView { get { return listView; } }

        public MasterPage()
        {
            InitializeComponent();

            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem
            {
                Title = AppResource.Home,
                IconSource = "icon.png",
                TargetType = typeof(HomePage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = AppResource.Home,
                IconSource = "icon.png",
                TargetType = typeof(HomePage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = AppResource.Home,
                IconSource = "icon.png",
                TargetType = typeof(HomePage)
            });

            listView.ItemsSource = masterPageItems;
        }
    }
}
