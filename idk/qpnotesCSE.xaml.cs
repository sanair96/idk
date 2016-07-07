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
    public sealed partial class qpnotesCSE : Page
    {
        public qpnotesCSE()
        {
            this.InitializeComponent();
        }

        private void bbut_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(studymaterialdepts));
        }

         async private void maths_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1n9YgEa"));
        }

        async private void maths1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1n9YmM4"));
        }

        async private void maths2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1OaVAPq"));
        }

       async private void maths3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1OaVOWV"));
        }

       async private void maths4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1OaW7Rr"));
        }

       async private void maths5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1OaWaNc"));
        }

       async private void EC_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://onedrive.live.com/redir?resid=EB83F0AA092D8326!136&authkey=!AKkgN9cvXWHsRq8&ithint=folder%2c"));
        }

       async private void EC1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1TNncMg"));
        }

       async private void EC2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1TNnfrs"));
        }

        async private void EC3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1TNnhj0"));
        }

       async private void EC4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1TNni6p"));
        }

       async private void EC5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1TNnjY3"));
        }

       async private void LD_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1JD4Wow"));
        }

      async private void LD1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1TNnEKy"));
        }

       async private void LD2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1TNnG4Z"));
        }

       async private void LD3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1TNnJ0I"));
        }

       async private void LD4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1TNnJOl"));
        }

       async private void LD5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1TNnMK2"));
        }

        async private void DMS_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1TNnUZU"));
        }

        async private void DMS1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1TNnVwN"));
        }

        async private void DMS2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1JD5gDL"));
        }

        async private void DMS3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1JD5j2f"));
        }

        async private void DMS4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1JD5las"));
        }

        async private void DMS5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1JD5niq"));
        }

        async private void DS_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1JD5GKd"));
        }
        async private void DS1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1JD5Ktn"));

        }
        async private void DS2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1JD5Lxu"));
        }
        async private void DS3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1JD5M4C"));
        }
        async private void DS4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1JD5MS5"));
        }
        async private void DS5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1JD5PNC"));
        }

       async private void OOP_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1TNoJSm"));
        }
        async private void OOP1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1TNoLKf"));
        }
        async private void OOP2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1TNoMO5"));
        }
        async private void OOP3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1TNoNlh"));
        }
        async private void OOP4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1TNoQxn"));
        }
        async private void OOP5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1TNoQ0q"));
        }
    }
}
