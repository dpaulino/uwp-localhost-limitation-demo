using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace LocalHostDemo
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

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            LoadingRing.IsActive = true;
            var handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (s, c, ch, err) => true;
            var client = new HttpClient(handler);
            using (var msg = new HttpRequestMessage(HttpMethod.Get, UrlBox.Text))
            {
                try
                {
                    var response = await client.SendAsync(msg);
                    var result = await response.Content.ReadAsStringAsync();
                    ResponseTextBlock.Text = result;
                }
                catch (Exception ex)
                {
                    ResponseTextBlock.Text = ex.Message;
                }
            }
            LoadingRing.IsActive = false;
        }
    }
}
