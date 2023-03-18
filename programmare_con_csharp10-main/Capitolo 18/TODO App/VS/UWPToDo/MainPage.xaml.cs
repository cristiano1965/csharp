using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Security.Cryptography.Certificates;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Newtonsoft.Json;
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPToDo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void BtCarica_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                PopulateDataGridView();
            }
            catch (Exception ex)
            {
                var dlg = new MessageDialog(ex.Message);
                await dlg.ShowAsync();
            }
        }

        private void PopulateDataGridView()
        {
            string apiUrl = "http://localhost:5000/api/Rest";
            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;

            string json = client.DownloadString(new Uri(apiUrl));
            var data = JsonConvert.DeserializeObject<List<TodoActivity>>(json);

            var model = new TodoActivityViewModel
            {
                Activities = data
            };
            this.DataContext = model;
        }
    }
}
