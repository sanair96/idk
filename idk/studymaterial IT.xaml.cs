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
    public sealed partial class studymaterial_IT : Page
    {
        public studymaterial_IT()
        {
            this.InitializeComponent();
        }

        private void bbut_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(studymaterialdepts));
        }


        private void ComboBoxItem1_Tapped(object sender, TappedRoutedEventArgs e)
        {
           
        }

        private void ComboBoxItem2_Tapped(object sender, TappedRoutedEventArgs e)
        {
           
        }

        private void ComboBoxItem3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(qpnotesIT));
        }

        private void ComboBoxItem4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(qpnotesIT4sem));
        }

        private void ComboBoxItem5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(qpnotesIT5sem));
        }

        private void ComboBoxItem6_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(qpnotesIT6sem));
        }
        
        private void ComboBoxItem7_Tapped(object sender, TappedRoutedEventArgs e)
        {
            
        }

        private void ComboBoxItem8_Tapped(object sender, TappedRoutedEventArgs e)
        {
            

        }
    }
}
