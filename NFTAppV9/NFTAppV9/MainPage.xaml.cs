using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NFTAppV9
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //Not in use
        private async void TrackButton_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new TouchTrackerPage());
            await Navigation.PushAsync(new NavigationPage(new HomePage()));
            //await Navigation.PushAsync(new NavigationPage(Android.Resource.Layout.activity_main.xml));
        }

        async void OnNextPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KissingBooth());
        }

        async void OnNextPageButtonClicked1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GalleryPage());
        }

        async void OnNextPageButtonClicked2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MarketplacePage());
        }
    }
}
