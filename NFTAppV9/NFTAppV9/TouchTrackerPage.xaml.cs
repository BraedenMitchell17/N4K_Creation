using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NFTAppV9
{
    public partial class TouchTrackerPage : ContentPage
    {
        public TouchTrackerPage()
        {
            InitializeComponent();
        }
        private async void DoneButton_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new DonePage());
            //await Navigation.PopAsync();
            await Navigation.PushAsync(new HomePage());
            
        }
    }
}



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//using Xamarin.Forms;
//using Xamarin.Forms.Xaml;

//namespace NFTAppV9
//{
//    [XamlCompilation(XamlCompilationOptions.Compile)]
//    public partial class TouchTrackerPage : ContentPage
//    {
//        public TouchTrackerPage()
//        {
//            InitializeComponent();
//        }
//    }
//}

