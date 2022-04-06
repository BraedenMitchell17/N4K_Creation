using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NFTAppV9
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShareConfirmPage : ContentPage
    {
        public ShareConfirmPage()
        {
            InitializeComponent();
        }

        async void OnNextPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NotImplementedYetScreen());
        }

        async void OnOutlookClicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri(String.Format("mailto:{0}", "")));
            //SendEmail();
        }

        //Attach the data as an attachment for the email
        public async Task SendEmail(string subject, string body, List<string> recipients)
        {
            try
            {
                var message = new EmailMessage
                {
                    Subject = "Hello",
                    Body = "World",
                };

                var fn = "Attachment.txt";
                var file = Path.Combine(FileSystem.CacheDirectory, fn);
                File.WriteAllText(file, "Hello World");

                message.Attachments.Add(new EmailAttachment(file));

                await Email.ComposeAsync(message);
            }
            catch (FeatureNotSupportedException fbsEx)
            {
                // Email is not supported on this device
            }
            catch (Exception ex)
            {
                // Some other exception occurred
            }


        }



        async void OnSMSClicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri(String.Format("sms:{0}", "")));
            //I want to attach have a way to attach the data somewhere here
        }

        
    }
}