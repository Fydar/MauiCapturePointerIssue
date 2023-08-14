using Microsoft.UI.Xaml;
using System;

namespace App1
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var targetUri = new Uri(addressBar.Text);
                MyWebView.Source = targetUri;
            }
            catch (FormatException)
            {
            }
        }
    }
}
