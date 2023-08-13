using Microsoft.Web.WebView2.Core;
using System.Windows;

namespace WPFSample
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeAsync();
        }

        private async void InitializeAsync()
        {
            await webView.EnsureCoreWebView2Async(null);
            webView.CoreWebView2.WebMessageReceived += UpdateAddressBar;
        }

        private void UpdateAddressBar(object sender, CoreWebView2WebMessageReceivedEventArgs args)
        {
            string uri = args.TryGetWebMessageAsString();
            addressBar.Text = uri;
        }

        private void ButtonGo_Click(object sender, RoutedEventArgs e)
        {
            if (webView != null && webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.Navigate(addressBar.Text);
            }
        }
    }
}
