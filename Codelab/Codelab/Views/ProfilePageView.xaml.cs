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
        public ProfilePageView(string Name, string Image, string Detail)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            html_url = Detail;
            name = Name;
            GithubButton.CommandParameter = Detail;
            UserName.Text = Name;
            UserDetails.Text = Detail;
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