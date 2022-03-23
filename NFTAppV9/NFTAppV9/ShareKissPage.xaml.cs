using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NFTAppV9
{
    //touch effect
    //Platfrom effect class
    //Onattached ondetached

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShareKissPage : ContentPage
    {
        string typeOfKiss;                                                                              //Try it just as a text file first
        string filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "kiss.txt");
        public ShareKissPage(string duration, string type)
        {
            InitializeComponent();
            lblDuration.Text = "Duration: " + duration;
            typeOfKiss = type;
            KissType.Text = type;
        }

        async void OnNextPageButtonClickedConfirm(object sender, EventArgs e)
        {
            if (!File.Exists(filename))
            {
                File.WriteAllText(filename, typeOfKiss + lblDuration.Text);
            }


            await Navigation.PushAsync(new ShareConfirmPage());
        }

        async void OnNextPageButtonClickedBack(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KissPage(typeOfKiss));
        }
    }
}