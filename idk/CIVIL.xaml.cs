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
using Windows.System;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace idk
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CIVIL : Page
    {
        public CIVIL()
        {
            this.InitializeComponent();
        }

        private void goback_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Departments));
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(aboutusCIVIL));
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //Frame.Navigate(typeof(studymaterialCIVIL));
        }

        private void details_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(civilwebview));
        }

     async   private void qp3_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPrh26Wb5u_hyCgqRK5"));
        }
        async private void qp4_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriQCIkhsyPF76ODXV"));
        }
        async private void qp5_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriQHy9nC8SqpoX4av"));
        }
        async private void qp6_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriQI0eaPtVPDXoBHT"));
        }
        async private void qp7_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriQO2SHSuex-k0435"));
        }
        async private void qp8_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriQTtOqhiJzpvylKn"));
        }

        async private void n3_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriHplLqsEpZfydPNv"));
        }
        async private void n4_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriHsGX_mASnsV8uOp"));
        }
        async private void n5_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriHwn3aJyU-JpgjfR"));
        }
        async private void n6_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriH3pVuR_nWxdKMDP"));
        }
        async private void n7_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriH5oqq_E8cQvgtT8"));
        }
        async private void n8_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriH9P4bTwENxzFKYY"));
        }


    }
}
