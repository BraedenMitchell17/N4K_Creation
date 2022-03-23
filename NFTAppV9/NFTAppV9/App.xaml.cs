using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NFTAppV9
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new NavigationPage(new MainPage());
            //HomePage homePage = new NavigationPage(new HomePage());
            //TypeOfKissPage TypePage = new TypeOfKissPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
