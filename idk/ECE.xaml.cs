using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
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
    public sealed partial class ECE : Page
    {
        public ECE()
        {
            this.InitializeComponent();
        }


        private void button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(aboutusECE));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //Frame.Navigate(typeof(studymaterialECE));
        }

        private void details_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ecewebview));
        }
        async private void qp3_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriRWG4Ey0-kGd6iP1"));
        }
        async private void qp4_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriRaJPmylq467tFD5"));
        }
        async private void qp5_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriRfWPHCHEezUQSSh"));
        }
        async private void qp6_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriRg41g6xAOcJT8ov"));
        }
        async private void qp7_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriRg41g6xAOcJT8ov"));
        }
        async private void qp8_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriRr7PNtViM05bXf3"));
        }

        async private void n3_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriQ5fYWQgNxL2VHrN"));
        }
        async private void n4_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriQ_tbp4Ckgeq7Jhm"));
        }
        async private void n5_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriRB-Iqh-f4_MWQoP"));
        }
        async private void n6_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriREK2-5xMhWBc50O"));
        }
        async private void n7_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriRIWPYA3qFSiDAuQ"));
        }
        async private void n8_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriROoAmjp8UWEc93n"));
        }
    }
}
