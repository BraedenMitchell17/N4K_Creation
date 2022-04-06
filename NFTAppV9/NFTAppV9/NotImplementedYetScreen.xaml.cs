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
    public partial class NotImplementedYetScreen : ContentPage
    {
        public NotImplementedYetScreen()
        {
            InitializeComponent();
        }

        async void OnNextPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}