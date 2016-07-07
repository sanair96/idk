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
    public sealed partial class qpnotesCSE5sem : Page
    {
        public qpnotesCSE5sem()
        {
            this.InitializeComponent();
        }

        private void bbut_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Studymaterial));
        }

       async private void SE_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1OZKgTy"));
        }
        async private void SE1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1OZKhXR"));
        }
        async private void SE2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1OZKg66"));
        }
        async private void SE3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1OZKjPk"));
        }
        async private void SE4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1OZKkmi"));
        }
        async private void SE5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1OZKkTw"));
        }

       async private void SS_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1RD4Uy1"));
        }
        async private void SS1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1RD4Xdf"));
        }
        async private void SS2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1RD51cQ"));
        }
        async private void SS3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1RD5091"));
        }
        async private void SS4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1RD548L"));
        }
        async private void SS5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1RD574d"));
        }

       async private void OS_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1RD5j3w"));
        }
        async private void OS1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1RD5g7J"));
        }
        async private void OS2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1RD5kVb"));
        }
        async private void OS3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1RD5oUM"));
        }
        async private void OS4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1RD5nQF"));
        }
        async private void OS5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1RD5rjo"));
        }

       async private void DBMS_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1OZLbDF"));
        }
        async private void DBMS1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1OZLfDh"));
        }
        async private void DBMS2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1OZLgHo"));
        }
        async private void DBMS3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1OZLfmT"));
        }
        async private void DBMS4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1OZLiPz"));
        }
        async private void DBMS5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1OZLluF"));
        }

       async private void CN_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1RD6csT"));
        }
        async private void CN1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1RD6gsz"));
        }
        async private void CN2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1RD6fos"));
        }
        async private void CN3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1RD6m3w"));
        }
        async private void CN4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1RD6kbV"));

        }
        async private void CN5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1RD6os9"));
        }

       async private void FL_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://1drv.ms/1RD6QXk"));
        }
        async private void FL1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1RD6Pm5"));
        }
        async private void FL2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1RD6QGW"));
        }
        async private void FL3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1RD6Why"));
        }
        async private void FL4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1RD6WON"));
        }
        async private void FL5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri(" http://1drv.ms/1RD6Vu9"));
        }
    }
}
