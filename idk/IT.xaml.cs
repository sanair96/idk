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
    public sealed partial class IT : Page
    {
        public IT()
        {
            this.InitializeComponent();
        }

       

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(aboutusIT));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //Frame.Navigate(typeof(studymaterial_IT));
        }

        private void details_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(itwebview));
        }
        async private void qp3_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriTvIGvmknyk3uP3c"));
        }
        async private void qp4_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriTwq4pW9-MzuJu31"));
        }
        async private void qp5_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriT330awRjbfkr5LU"));
        }
        async private void qp6_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriT6dV0srjfVGEK1u"));
        }
        async private void qp7_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriT8TbcuHODwJwiQU"));
        }
        async private void qp8_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriUBqBwQm9fPS8XKI"));
        }

        async private void n3_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriTRT4gm3O9VFZXM1"));
        }
        async private void n4_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriTUl99oGcPFEn1tM"));
        }
        async private void n5_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriTaECIJSrywz0bzT"));
        }
        async private void n6_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriTdI-ExIr4anoh30"));
        }
        async private void n7_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriTgC8dc09ogVcbYc"));
        }
        async private void n8_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriTndVC2kKz54PAzv"));
        }


    }
}
