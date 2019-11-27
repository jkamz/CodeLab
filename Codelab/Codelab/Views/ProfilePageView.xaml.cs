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
    public partial class ProfilePageView : ContentPage
    {
        string html_url;
        string name;
        ProfileViewModel viewModel = new ProfileViewModel();
        public ProfilePageView(string Name, string Image, string Detail)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            html_url = Detail;
            name = Name;
            GithubButton.CommandParameter = Detail;
            UserName.Text = Name;
            UserDetails.Text = ProfileViewModel.UserProfile.name;
            RepoCount.Text = (ProfileViewModel.UserProfile.public_repos).ToString();
            FollowingCount.Text = (ProfileViewModel.UserProfile.following).ToString();
            FollowersCount.Text = (ProfileViewModel.UserProfile.followers).ToString();
            UserPic.Source = new UriImageSource()
            {
                Uri = new Uri(Image)
            };
        }


        public async void GithubButton_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync(html_url, BrowserLaunchMode.SystemPreferred);
        }

        private async void ShareButton_Clicked(object sender, EventArgs e)
        {
            await Share.RequestAsync(new ShareTextRequest
            {
                Uri = html_url,
                Title = $"Check out this awesome developer @{name}, {html_url}."
            });
        }
    }
}