using Codelab.Models;
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
        ListUsersViewModel viewModel = new ListUsersViewModel();

        public HomePage()
        {
            InitializeComponent();
            BindingContext = viewModel;
            NavigationPage.SetHasNavigationBar(this, false);

            CoverWrapper.HeightRequest = (DeviceDisplay.MainDisplayInfo.Height / DeviceDisplay.MainDisplayInfo.Density);
            DataWrapper.HeightRequest = (DeviceDisplay.MainDisplayInfo.Height / DeviceDisplay.MainDisplayInfo.Density);
            DataWrapper.TranslateTo(0, DataWrapper.HeightRequest, length: 0);
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await viewModel.GetUsers();
        }

        public void Handle_Swiped(object sender, SwipedEventArgs e)
        {
            CoverWrapper.TranslateTo(0, (CoverWrapper.Y - CoverWrapper.HeightRequest), length: 300, easing: Easing.CubicInOut);
            DataWrapper.TranslateTo(0, 0, length: 300, easing: Easing.CubicInOut);
        }

        private async void User_Tapped(object sender, ItemTappedEventArgs e)
        {
            var userdetails = e.Item as ListUsersModel;
            await ProfileViewModel.GetUser();
            await Navigation.PushAsync(new ProfilePageView(userdetails.login, userdetails.avatar_url, userdetails.html_url));
        }
    }
}