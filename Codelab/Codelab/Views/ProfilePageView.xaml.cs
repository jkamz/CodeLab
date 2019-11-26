using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Codelab.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePageView : ContentPage
    {
        public ProfilePageView(string Name, string Image, string Detail)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            UserName.Text = Name;
            UserDetails.Text = Detail;
            UserPic.Source = new UriImageSource()
            {
                Uri = new Uri(Image)
            };
        }
    }
}