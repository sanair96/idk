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
    public sealed partial class studymaterialdepts : Page
    {
        public studymaterialdepts()
        {
            this.InitializeComponent();
        }

        private void ComboBoxItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(Studymaterial));
        }

        private void ComboBoxItem_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(studymaterialECE));
        }

        private void ComboBoxItem_Tapped_2(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(studymaterialEEE));
        }

        private void ComboBoxItem_Tapped_3(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(studymaterial_IS));
        }

        private void ComboBoxItem_Tapped_4(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(studymaterial_IT));

        }

        private void ComboBoxItem_Tapped_5(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(studymaterialMECH));
        }

        private void ComboBoxItem_Tapped_6(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(studymaterialCIVIL));
        }
    }
}
