using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NFTAppV9
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KissingBooth : ContentPage
    {
        public KissingBooth()
        {
            InitializeComponent();
        }

        async void OnNextPageButtonClickedTypeOfKiss(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TypeOfKissPage());
        }

        async void OnNextPageButtonClickedKiss(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KissPage("Forehead"));
        }

        async void OnNextPageButtonClickedShare(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NotImplementedYetScreen());
        }
    }
}