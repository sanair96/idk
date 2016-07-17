using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace idk
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class abtuswebview : Page
    {
        ProgressRing a = new ProgressRing();
        public abtuswebview()
        {
            this.InitializeComponent();
            string site = "http://www.rnsit.ac.in/index.html";
            WebView.Navigate(new Uri(site, UriKind.Absolute));
            a.Height = 50;
            a.Width = 50;
            a.VerticalAlignment = VerticalAlignment.Center;
            a.HorizontalAlignment = HorizontalAlignment.Center;
            a.FlowDirection = FlowDirection.LeftToRight;
            a.Visibility = Visibility.Visible;
        }

        private void WebView_Loading(FrameworkElement sender, object args)
        {
            a.IsActive = true;
            
        }

        private void WebView_Loaded(object sender, RoutedEventArgs e)
        {
            a.IsActive = false;
        }
    }
}
