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
    public sealed partial class qpnotesCSE6sem : Page
    {
        public qpnotesCSE6sem()
        {
            this.InitializeComponent();
        }

        private void bbut_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Studymaterial));
        }

        async private void ME_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1N0LGff"));
        }
        async private void ME1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1N0LH31"));
        }
        async private void ME2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1N0LJIf"));
        }
        async private void ME3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1N0LKvB"));
        }
        async private void ME4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1N0LKM5"));
        }
        async private void ME5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1N0LLjj"));
        }

       async private void US_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1SbwpQV"));
        }
        async private void US1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1Sbwsfm"));
        }
        async private void US2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1N0M3qe"));
        }
        async private void US3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1N0M25L "));

        }
        async private void US4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1N0M2mj"));
        }
        async private void US5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1N0M8dv "));
        }

       async private void CD_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1N0Mpgt "));
        }
        async private void CD1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1N0MqRG "));
        }
        async private void CD2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1N0MroN "));
        }
        async private void CD3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1N0MvVt "));
        }
        async private void CD4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1N0MBwp"));
        }
        async private void CD5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1N0MEZ2 "));
        }

       async private void CN_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1N0MHUO "));
        }

        async private void CN1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1N0MIrU "));
        }

        async private void CN2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1N0MKjq "));
        }

        async private void CN3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1N0MLnq "));
        }

        async private void CN4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1N0MOQ0 "));
        }

        async private void CN5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1N0MP6J"));
        }

       async private void OR_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1N0MVv1"));
        }
        async private void OR1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1N0MZek"));
        }
        async private void OR2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1N0MZLg"));
        }
        async private void OR3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1N0N01X"));
        }
        async private void OR4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1N0N2H3"));
        }
        async private void OR5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1N0N1CR"));
        }

       async private void DC_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1SbwZOk"));
        }
        async private void DC1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1Sbx04X"));
        }
        async private void DC2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1Sbx0BS"));
        }
        async private void DC3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1Sbx3Of"));
        }
        async private void DC4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1Sbx4la"));
        }
        async private void DC5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1Sbx6JN"));
        }

       async private void CG_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1Sbx98F"));
        }
        async private void CG1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1Sbx9Fr"));
        }
        async private void CG2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1Sbx9W1"));
        }
        async private void CG3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1SbxckQ"));
        }
        async private void CG4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1SbxcRH"));
        }
        async private void CG5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1Sbxb0a"));
        }
    }
}
