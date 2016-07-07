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
    public sealed partial class studymaterialECE : Page
    {
        public studymaterialECE()
        {
            this.InitializeComponent();
        }

        private void goback_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(studymaterialdepts));
        }

        private void textBlock1_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {

        }

        private void comboBox_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void ComboBoxItem_Tapped1(object sender, TappedRoutedEventArgs e)
        {
            
        }

        private void ComboBoxItem_Tapped2(object sender, TappedRoutedEventArgs e)
        {
            
        }
        private void ComboBoxItem_Tapped3(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(qpnotesECE));
        }
        private void ComboBoxItem_Tapped4(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(qpnotesECE4sem));
        }
        private void ComboBoxItem_Tapped5(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(qpnotesECE5sem));
        }
        private void ComboBoxItem_Tapped6(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(qpnotesECE6sem));
        }
        private void ComboBoxItem_Tapped7(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(qpnotesECE7sem));
        }
        private void ComboBoxItem_Tapped8(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(qpnotesECE8sem));
        }
    }
}
