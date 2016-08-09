using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Media.Imaging;
using Windows.Media.PlayTo;
using Windows.System;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace idk
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Departments : Page
    {
       

        public Departments()
        {
            this.InitializeComponent();
        }
        //image slide show
        Image a = new Image();
        DispatcherTimer playlistTimer1 = null;
        List<string> Images1 = new List<string>();
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            ImageSource1();
        }
        private void ImageSource1()
        {   
            Images1.Add("d1.jpg");
            Images1.Add("d2.jpg");
            Images1.Add("d3.jpg");
            Images1.Add("d4.jpg");
            Images1.Add("d5.jpg");
            Images1.Add("d6.jpg");
            playlistTimer1 = new DispatcherTimer();
            playlistTimer1.Interval = new TimeSpan(0, 0, 3);
            playlistTimer1.Tick += playlistTimer_Tick1;
            image.Source = new BitmapImage(new Uri("ms-appx:///Assets/" + Images1[count1]));
            a.Source = new BitmapImage(new Uri("ms-appx:///Assets/" + Images1[count1]));
            a.Width = 350;
            a.Height = 200;
            a.Stretch = Stretch.Fill;
            image.Width = 350;
            image.Height = 200;
            image.Stretch = Stretch.Fill;

            playlistTimer1.Start();
        }
        int count1 = 0;
        void playlistTimer_Tick1(object sender, object e)
        {
            if (Images1 != null)
            {
                if (count1 < Images1.Count)
                    count1++;

                if (count1 >= Images1.Count)
                    count1 = 0;

                ImageRotation1();
            }
        }
        private void ImageRotation1()
        {
            if (count1 % 2 == 0)
            {
                image.Source = new BitmapImage(new Uri("ms-appx:///Assets/" + Images1[count1].ToString()));
                Cont.Content = image;
            }
            else
            {
                a.Source = new BitmapImage(new Uri("ms-appx:///Assets/" + Images1[count1].ToString()));
                Cont.Content = a;
            }
        }
    


private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CSE));
        }

        private void goback_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ECE));
        }

        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EEE));
        }

        private void button_Copy3_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(IT));
        }

        private void button_Copy4_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CIVIL));
        }

        private void button_Copy6_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(IS));
        }

        private void button_Copy5_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MECH));
        }
        public void OnBackRequested(object sender, BackRequestedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void MenuFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(CSE));
        }

        private void MenuFlyoutItem_Click_1(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ECE));
        }

        private void MenuFlyoutItem_Click_2(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(EEE));
        }

        private void MenuFlyoutItem_Click_3(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(IS));
        }

        private void MenuFlyoutItem_Click_4(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(IT));
        }

        private void MenuFlyoutItem_Click_5(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MECH));
        }

        private void MenuFlyoutItem_Click_6(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(CIVIL));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuFlyoutItem_Click_7(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(mathdept));
        }

        private void MenuFlyoutItem_Click_8(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(phydept));
        }

        private void MenuFlyoutItem_Click_9(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(chemdept));
        }

        private void MenuFlyoutItem_Click_10(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(deptmca));
        }

      async private void MenuFlyoutItem_Click_11(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("http://www.rnsitmba.ac.in/"));
        }
    }
}
