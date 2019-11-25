using Codelab.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Codelab.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            BindingContext = new ListUsersViewModel();

            CoverWrapper.HeightRequest = (DeviceDisplay.MainDisplayInfo.Height / DeviceDisplay.MainDisplayInfo.Density);
            DataWrapper.HeightRequest = (DeviceDisplay.MainDisplayInfo.Height / DeviceDisplay.MainDisplayInfo.Density);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            DataWrapper.TranslateTo(0, DataWrapper.HeightRequest, length: 0);
        }

        public async void Handle_Swiped(object sender, SwipedEventArgs e)
        {
            CoverWrapper.TranslateTo(0, (CoverWrapper.Y - CoverWrapper.HeightRequest), length: 300, easing: Easing.CubicInOut);
            DataWrapper.TranslateTo(0, 0, length: 300, easing: Easing.CubicInOut);
            //ScrollWrapper.ScrollToAsync(0, 0, false);
        }

        private void User_Tapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}