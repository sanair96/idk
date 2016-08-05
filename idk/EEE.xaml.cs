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
    public sealed partial class EEE : Page
    {
        public EEE()
        {
            this.InitializeComponent();
        }

        private void goback_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Departments));
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(aboutusEEE));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
           // Frame.Navigate(typeof(studymaterialEEE));
        }

        private void details_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(eewebview));
        }
        async private void qp3_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriSSOhrVBOTxdn_7F"));
        }
        async private void qp4_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriSWVGP8Z2_HwVjFg"));
        }
        async private void qp5_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriSa_PA7ppyzfICqu"));
        }
        async private void qp6_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriSf7Z1XOxqLq57W0"));
        }
        async private void qp7_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriSjaJFSEpW362MwR"));
        }
        async private void qp8_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriSkDuD8E4gQl_0la"));
        }

        async private void n3_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriR1AvYmkXbDxf_7w"));
        }
        async private void n4_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriR6MGvKiglI21kpC"));
        }
        async private void n5_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriR_4lBwqAlRqim6Q"));
        }
        async private void n6_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriSBorx-S4Y_Bmr-j"));
        }
        async private void n7_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriSF6hVbgfCm-OhQX"));
        }
        async private void n8_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriSLHb1_S9ukdzrp_"));
        }
    }
}
