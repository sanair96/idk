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
    public sealed partial class qpnotesCSE4sem : Page
    {
        public qpnotesCSE4sem()
        {
            this.InitializeComponent();
        }

        private void bbut_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Studymaterial));
        }

       async private void math_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1UGND6w"));
        }
        async private void math1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1UGNOyE"));
        }
        async private void math2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1UGNS1e"));
        }
        async private void math3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1UGNUGk"));
        }
        async private void math4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1UGNT5s"));
        }
        async private void math5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1UGNTCi"));
        }

       async private void GT_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1UGO0Ot"));
        }
        async private void GT1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1UGO1C3"));
        }
        async private void GT2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1UGO54x"));
        }
        async private void GT3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1UGO5lh"));
        }
        async private void GT4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1UGO40C"));
        }
        async private void GT5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1UGO6FP"));
        }

       async private void DA_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1UGO8NT"));
        }
        async private void DA1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1UGOfJl"));
        }
        async private void DA2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1UGOeoB"));
        }
        async private void DA3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1UGOgwK"));
        }
        async private void DA4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1UGOfc6"));
        }
        async private void DA5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1UGOhAJ"));
        }

       async private void US_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1UGOnbN"));
        }
        async private void US1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1nbaRao"));
        }
        async private void US2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1nbaRHo"));
        }
        async private void US3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1nbaSuO"));
        }
        async private void US4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1nbaUTr"));
        }
        async private void US5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1nbaTit"));
        }

       async private void MP_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("  http://1drv.ms/1UGOEvl"));
        }
        async private void MP1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("  http://1drv.ms/1nbb3X6"));
        }
        async private void MP2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("  http://1drv.ms/1nbb5OG"));
        }
        async private void MP3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("  http://1drv.ms/1nbb4u0"));
        }
        async private void MP4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("  http://1drv.ms/1nbb4KL"));

        }
        async private void MP5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("  http://1drv.ms/1nbb8db"));
        }

      async  private void CO_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1UGOTGH"));
        }
        async private void CO1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("  http://1drv.ms/1UGOUdM"));
        }
        async private void CO2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("  http://1drv.ms/1UGOUKM"));
        }
        async private void CO3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("  http://1drv.ms/1UGOVhL"));
        }
        async private void CO4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1UGOVOK"));
        }
        async private void CO5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1UGOW5n"));
        }

    }
}
