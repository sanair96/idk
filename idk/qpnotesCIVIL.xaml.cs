﻿using System;
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
    public sealed partial class qpnotesCIVIL : Page
    {
        public qpnotesCIVIL()
        {
            this.InitializeComponent();
        }

      

       async private void textBlock_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPrh3PyksM_-Wp4cftM"));
        }

     async private void textBlock1_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPrlB2l5xLmL2WzPKso"));
        }

       async private void textBlock_Copy_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPrh3Hea7ycyFL0ECEG"));
        }

     async   private void textBlock_Copy1_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPrsi5PdtkUNKSVLiE5"));
        }
    }
}
