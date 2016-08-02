using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Media.Imaging;
using Windows.Media.PlayTo;
using Windows.Foundation.Metadata;
using Windows.UI.ViewManagement;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace idk
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {


        public MainPage()
        {
            InitializeComponent();
            if (ApiInformation.IsTypePresent("Windows.UI.ViewManagement.ApplicationView"))
            {
                var titleBar = ApplicationView.GetForCurrentView().TitleBar;
                if (titleBar != null)
                {
                    titleBar.ButtonBackgroundColor = Color.FromArgb(0, 111, 201, 138);
                    titleBar.ButtonForegroundColor = Colors.White;
                    titleBar.BackgroundColor = Color.FromArgb(0, 111, 201, 138);
                    titleBar.ForegroundColor = Colors.White;
                }
            }

            if (ApiInformation.IsTypePresent("Windows.UI.ViewManagement.StatusBar"))
            {

                var statusBar = StatusBar.GetForCurrentView(); 
                if (statusBar != null)
                {
                    statusBar.BackgroundOpacity = 1;
                    statusBar.BackgroundColor = Color.FromArgb(0,111,201,138);
                    statusBar.ForegroundColor = Colors.White;
                }
            }
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
            Images1.Add("mp.jpg");
            Images1.Add("mp1.jpg");
            Images1.Add("mp2.jpg");
            Images1.Add("mp3.jpg");
            Images1.Add("mp4.jpg");
            Images1.Add("mp5.jpg");
            Images1.Add("mp6.jpg");
            playlistTimer1 = new DispatcherTimer();
            playlistTimer1.Interval = new TimeSpan(0, 0, 1);
            playlistTimer1.Tick += playlistTimer_Tick1;
            image1.Source = new BitmapImage(new Uri("ms-appx:///Assets/" + Images1[count1]));
            a.Source = new BitmapImage(new Uri("ms-appx:///Assets/" + Images1[count1]));
            a.Width = 350;
            a.Height = 200;
            a.Stretch = Stretch.UniformToFill;
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
                image1.Source = new BitmapImage(new Uri("ms-appx:///Assets/" + Images1[count1].ToString()));
                Cont.Content = image1;
            }
            else
            {
                a.Source = new BitmapImage(new Uri("ms-appx:///Assets/" + Images1[count1].ToString()));
                Cont.Content = a;
            }
        }




        private void textBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
        private void Hamburgerbutton_click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;

        }

        private void Hamburger_Click(object sender, RoutedEventArgs e)
        {
           
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
            Cont.Visibility = Visibility.Visible;
            RNSITLOGO.Visibility = Visibility.Visible;
            courses.Visibility = Visibility.Collapsed;
            courseslink.Visibility = Visibility.Collapsed;
            contactus.Visibility = Visibility.Collapsed;
        }

 

        private void departments_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
            this.Frame.Navigate(typeof(Departments));
        }
      

        private void MenuButton2_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
            this.Frame.Navigate(typeof(Departments));
        }

        private void Study_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
            this.Frame.Navigate(typeof(studymaterialdepts));
        }

        private void Menubutton4_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
            this.Frame.Navigate(typeof(Departments));
        }

        private void MenuButton1_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
           // this.Frame.Navigate(typeof(admissions));
        }

        private void MenuButton8_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
            this.Frame.Navigate(typeof(facility));
        }

        private void Facilties_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
            this.Frame.Navigate(typeof(facility));
        }

        private void MenuButton7_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
            this.Frame.Navigate(typeof(Transport));
        }

        private void trasnport_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
            this.Frame.Navigate(typeof(Transport));
        }

        private void MenuButton5_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
            Frame.Navigate(typeof(Hostel));
        }

        private void Hostel_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
            Frame.Navigate(typeof(Hostel));
        }

        private void MenuButton3_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
            Frame.Navigate(typeof(placements));
        }

        private void placements_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
            Frame.Navigate(typeof(placements));
        }

        private void Event_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
            Frame.Navigate(typeof(page_maintainance));
        }

        private void Campus_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
            Frame.Navigate(typeof(page_maintainance));
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            Cont.Visibility = Visibility.Visible;
            RNSITLOGO.Visibility = Visibility.Visible;
            courses.Visibility = Visibility.Collapsed;
            courseslink.Visibility = Visibility.Collapsed;
            Frame.Navigate(typeof(aboutus));
        }

        private void AppBarButton_Click_1(object sender, RoutedEventArgs e)
        {
            if (contactus.Visibility == Visibility.Collapsed)
            {
                Cont.Visibility = Visibility.Collapsed;
                RNSITLOGO.Visibility = Visibility.Collapsed;
                contactus.Visibility = Visibility.Visible;
                courses.Visibility = Visibility.Collapsed;
                courseslink.Visibility = Visibility.Collapsed;
            }
            else
            {
                Cont.Visibility = Visibility.Visible;
                RNSITLOGO.Visibility = Visibility.Visible;
                contactus.Visibility = Visibility.Collapsed;
                courses.Visibility = Visibility.Collapsed;
                courseslink.Visibility = Visibility.Collapsed;
            }
        }

       async private void AppBarButton_Click_2(object sender, RoutedEventArgs e)
        {
            // Center on RNSIT
     //       var urirnscen = new Uri("bingmaps:? cp = 12.902260~77.518974 & lvl = 14");
            var uriRns = new Uri(@"bingmaps:?collection=point.12.902260_77.518974_RNSIT&lvl=18");
            // Launch the Windows Maps app
            var launcherOptions = new Windows.System.LauncherOptions();
            launcherOptions.TargetApplicationPackageFamilyName = "Microsoft.WindowsMaps_8wekyb3d8bbwe";
   //         var center = await Launcher.LaunchUriAsync(urirnscen, launcherOptions);
            var success = await Windows.System.Launcher.LaunchUriAsync(uriRns,launcherOptions);
            
            Cont.Visibility = Visibility.Visible;
            RNSITLOGO.Visibility = Visibility.Visible;
            contactus.Visibility = Visibility.Collapsed;
            courses.Visibility = Visibility.Collapsed;
            courseslink.Visibility = Visibility.Collapsed;
          //  await Launcher.LaunchUriAsync(new Uri("http://binged.it/20zshMf"));
        }

        private void courses_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void AppBarButton_Click_3(object sender, RoutedEventArgs e)
        {
            if (courses.Visibility == Visibility.Collapsed)
            {
                contactus.Visibility = Visibility.Collapsed;
                Cont.Visibility = Visibility.Collapsed;
                RNSITLOGO.Visibility = Visibility.Collapsed;
                courses.Visibility = Visibility.Visible;
                courseslink.Visibility = Visibility.Visible;
            }
            else
            {
                contactus.Visibility = Visibility.Collapsed;
                Cont.Visibility = Visibility.Visible;
                RNSITLOGO.Visibility = Visibility.Visible;
                courses.Visibility = Visibility.Collapsed;
                courseslink.Visibility = Visibility.Collapsed;
            }
        }


       async private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("http://www.rnsit.ac.in/courses.html"));
        }

        private void AppBarButton_Click_4(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(creator));
        }
    }
}
