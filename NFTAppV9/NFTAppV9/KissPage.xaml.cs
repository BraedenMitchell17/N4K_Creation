using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NFTAppV9
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KissPage : ContentPage
    {
        Timer timer = new Timer();
        string typeOfKiss;

        public KissPage(string type)
        {
            InitializeComponent();
            typeOfKiss = type;
        }

        private async void DoneButton_Clicked(object sender, EventArgs e)
        {
                                                                    //Initally for the duration now?
            await Navigation.PushAsync(new ShareKissPage("temp", typeOfKiss));
        }

    }
}