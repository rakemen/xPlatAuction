using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Microsoft.WindowsAzure.MobileServices;

namespace xPlatAuction
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            message.Text = "Loading items...";

            // TODO: change to IIS & localDb
            //MobileServiceClient client = new MobileServiceClient(
            //    "https://xplatauctionbackendrcm.azurewebsites.net/");
            MobileServiceClient client = new MobileServiceClient(
                "http://192.168.1.82/xPlatAuction");

            var items = await client.GetTable<TodoItem>().ReadAsync();
            var item = items.First();
            message.Text = item.Text;
        }
    }
}
