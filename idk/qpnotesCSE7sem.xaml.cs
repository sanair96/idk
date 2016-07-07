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
    public sealed partial class qpnotesCSE7sem : Page
    {
        public qpnotesCSE7sem()
        {
            this.InitializeComponent();
        }

        private void bbut_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Studymaterial));
        }

       async private void OD(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1mXCy6K"));
        }
        async private void OD1(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1mXCNys"));
        }
        async private void OD2(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1mXCUu7"));

        }
        async private void OD3(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1mXCZ0G"));
        }
        async private void OD4(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1mXD0BK"));
        }
        async private void OD5(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1mXD5pf"));
        }

       async private void SA_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1OhJYKJ"));
        }
        async private void SA1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1mXE9cP"));
        }
        async private void SA2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1mXEewV"));
        }
        async private void SA3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1mXEcoR"));
        }
        async private void SA4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1mXEhZP"));
        }
        async private void SA5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1mXEpsh"));
        }

       async private void PW_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1mXENqw"));
        }

        async private void PW1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1mXF2Sw"));
        }

        async private void PW2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1mXFgJj"));
        }

        async private void PW3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1mXFosd"));
        }

        async private void PW4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1mXFr7t"));
        }

        async private void PW5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1mXFxff"));
        }

       async private void ECS_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1OhKFUq"));
        }
        async private void ECS1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1OhKI2t"));
        }


        async private void ECS2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1OhKGYr"));
        }

        async private void ECS3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1OhKJUa"));
        }

        async private void ECS4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1OhKJDo"));
        }

        async private void ECS5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1OhKN6h"));
        }
    }
}
