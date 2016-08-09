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
            playlistTimer1.Interval = new TimeSpan(0, 0, 3);
            playlistTimer1.Tick += playlistTimer_Tick1;
            image1.Source = new BitmapImage(new Uri("ms-appx:///Assets/" + Images1[count1]));
            a.Source = new BitmapImage(new Uri("ms-appx:///Assets/" + Images1[count1]));
            a.Width = 350;
            a.Height = 200;
            a.Stretch = Stretch.Fill;
            image1.Width=350;
            image1.Height = 200;
            image1.Stretch = Stretch.Fill;

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
                /*int i;
                for (i=0;i<100000;i++)
                {
                    image1.Opacity = image1.Opacity - 0.00001;
                    Cont.Content = image1;
                }
                for (i = 0; i < 1000000; i++)
                {
                    image1.Opacity = image1.Opacity + 0.000001;
                    Cont.Content = image1;
                }*/

            }
            else
            {
                a.Source = new BitmapImage(new Uri("ms-appx:///Assets/" + Images1[count1].ToString()));
                Cont.Content = a;
                /*int i;
                for (i = 0; i <1000000; i++)
                {
                    a.Opacity = a.Opacity - 0.000001;
                    Cont.Content = a;
                }
                for (i = 0; i < 100000; i++)
                {
                    a.Opacity = a.Opacity +  0.00001;
                    Cont.Content = a;
                }*/

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
            //this.Frame.Navigate(typeof(studymaterialdepts));
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
            Frame.Navigate(typeof(aboutus));
        }

        private void AppBarButton_Click_1(object sender, RoutedEventArgs e)
        {
           // MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
            Frame.Navigate(typeof(contactus));
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
          //  await Launcher.LaunchUriAsync(new Uri("http://binged.it/20zshMf"));
        }

        private void courses_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void AppBarButton_Click_3(object sender, RoutedEventArgs e)
        {
            //MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
            Frame.Navigate(typeof(courses));
        }


       
        private void AppBarButton_Click_4(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(creator));
        }

        async private void MenuFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPrh3xlbvtbOkkAF8GO"));
        }

        async private void MenuFlyoutItem_Click_1(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPrh2tcbo0POTPPTGKP"));
        }

        async private void MenuFlyoutItem_Click_2(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPrh3YxUhyD6ClU1tT5"));
        }

        async private void MenuFlyoutItem_Click_3(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPrh2ngK-w-Qe5cTCKT"));
        }

        async private void MenuFlyoutItem_Click_4(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriWrUB5P-yFDnqVcv"));
        }

        async private void MenuFlyoutItem_Click_5(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriQbMKtxd3FeWmoqe"));
        }

        async private void MenuFlyoutItem_Click_6(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPrihXnKjdNpCbBrY6n"));
        }

        async private void MenuFlyoutItem_Click_7(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriQdJOxrPNisVtogK"));
        }

        async private void MenuFlyoutItem_Click_8(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPrikC82v7FkW6nDAgO"));
        }

        async private void MenuFlyoutItem_Click_9(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriQj1q6PMjm5fJXdu"));
        }

        async private void MenuFlyoutItem_Click_10(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPrimu5VawVc7a8zdAz"));
        }

        async private void MenuFlyoutItem_Click_11(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriQWuxHZhAW2rtPj1"));
        }

        async private void MenuFlyoutItem_Click_12(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriUmf-B89dcajhsHo"));
        }

        async private void MenuFlyoutItem_Click_13(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriQoO1rgX1yCUdQ8M"));
        }

        async private void MenuFlyoutItem_Click_14(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriVpXzQZanaJzsuuu"));
        }

        async private void MenuFlyoutItem_Click_15(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriQt_MWIYtBu60OcT"));
        }

        async private void MenuFlyoutItem_Click_16(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriRWG4Ey0-kGd6iP1"));
        }

        async private void MenuFlyoutItem_Click_17(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriQ5fYWQgNxL2VHrN"));
        }

        async private void MenuFlyoutItem_Click_18(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriRaJPmylq467tFD5"));
        }

        async private void MenuFlyoutItem_Click_19(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriQ_tbp4Ckgeq7Jhm"));
        }

        async private void MenuFlyoutItem_Click_20(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriRfWPHCHEezUQSSh"));
        }

        async private void MenuFlyoutItem_Click_21(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriQ10Z9OHP6FlnyYW"));
        }

        async private void MenuFlyoutItem_Click_22(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriRg41g6xAOcJT8ov"));
        }

        async private void MenuFlyoutItem_Click_23(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriQ10Z9OHP6FlnyYW"));
        }

        async private void MenuFlyoutItem_Click_24(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriRmFWqIk6EibfAl0"));
        }

        async private void MenuFlyoutItem_Click_25(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriRIWPYA3qFSiDAuQ"));
        }

        async private void MenuFlyoutItem_Click_26(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriRr7PNtViM05bXf3"));
        }

        async private void MenuFlyoutItem_Click_27(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriROoAmjp8UWEc93n"));
        }

        async private void MenuFlyoutItem_Click_28(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriSSOhrVBOTxdn_7F"));
        }

        async private void MenuFlyoutItem_Click_29(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriR1AvYmkXbDxf_7w"));
        }

        async private void MenuFlyoutItem_Click_30(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriSWVGP8Z2_HwVjFg"));
        }

        async private void MenuFlyoutItem_Click_31(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriR6MGvKiglI21kpC"));
        }

        async private void MenuFlyoutItem_Click_32(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriSa_PA7ppyzfICqu"));
        }

        async private void MenuFlyoutItem_Click_33(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriR_4lBwqAlRqim6Q"));
        }

        async private void MenuFlyoutItem_Click_34(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriSf7Z1XOxqLq57W0"));
        }

        async private void MenuFlyoutItem_Click_35(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriSBorx-S4Y_Bmr-j"));
        }

        async private void MenuFlyoutItem_Click_36(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriSjaJFSEpW362MwR"));
        }

        async private void MenuFlyoutItem_Click_37(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriSGpMo0th4KhhGhg"));
        }

        async private void MenuFlyoutItem_Click_38(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriSkDuD8E4gQl_0la"));
        }

        async private void MenuFlyoutItem_Click_39(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriSLHb1_S9ukdzrp_"));
        }

        async private void MenuFlyoutItem_Click_40(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPrix5imNOxqYogCsYU"));
        }

        async private void MenuFlyoutItem_Click_41(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriSw7Dr3FXX0p1NkJ"));
        }

        async private void MenuFlyoutItem_Click_42(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriyaAJY6IX9z2t-0j"));
        }

        async private void MenuFlyoutItem_Click_43(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriS2cXASNriDt8xXn"));
        }

        async private void MenuFlyoutItem_Click_44(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPri1H6EFMsXmaTwr52"));
        }

        async private void MenuFlyoutItem_Click_45(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriS5Qi0YG5R6Rk7NA"));
        }

        async private void MenuFlyoutItem_Click_46(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPri3zhIZ6JtdYLVSSY"));
        }

        async private void MenuFlyoutItem_Click_47(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriS-vKb4GCJPLAhSz"));
        }

        async private void MenuFlyoutItem_Click_48(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPrjEqiwYIxnOza8Ifd"));
        }

        async private void MenuFlyoutItem_Click_49(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriTBhTouvFgQaMYkp"));
        }

        async private void MenuFlyoutItem_Click_50(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPrjTQhQlUXzTayTqhR"));
        }

        async private void MenuFlyoutItem_Click_51(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriTEIw-JZPqN-BN97"));
        }

        async private void MenuFlyoutItem_Click_52(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriTvIGvmknyk3uP3c"));
        }

        async private void MenuFlyoutItem_Click_53(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriTRT4gm3O9VFZXM1"));
        }

        async private void MenuFlyoutItem_Click_54(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriTwq4pW9-MzuJu31"));
        }

        async private void MenuFlyoutItem_Click_55(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriTUl99oGcPFEn1tM"));
        }

        async private void MenuFlyoutItem_Click_56(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriT330awRjbfkr5LU"));
        }

        async private void MenuFlyoutItem_Click_57(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriTaECIJSrywz0bzT"));
        }

        async private void MenuFlyoutItem_Click_58(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriT6dV0srjfVGEK1u"));
        }

        async private void MenuFlyoutItem_Click_59(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriTdI-ExIr4anoh30"));
        }

        async private void MenuFlyoutItem_Click_60(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriT8TbcuHODwJwiQU"));
        }

        async private void MenuFlyoutItem_Click_61(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriTgC8dc09ogVcbYc"));
        }

        async private void MenuFlyoutItem_Click_62(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriUBqBwQm9fPS8XKI"));
        }

        async private void MenuFlyoutItem_Click_63(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriTndVC2kKz54PAzv"));
        }

        async private void MenuFlyoutItem_Click_64(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriCegZen9fyZEHV23"));
        }

        async private void MenuFlyoutItem_Click_65(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriULVQH1JQppn3cVH"));
        }

        async private void MenuFlyoutItem_Click_66(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriDGYkSJ-FNRXOVQ9"));
        }

        async private void MenuFlyoutItem_Click_67(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriUNyhBYq-IikQT0a"));
        }

        async private void MenuFlyoutItem_Click_68(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriDtWrl2tHZ7By_87"));
        }

        async private void MenuFlyoutItem_Click_69(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriUS3kHeG366Oc90s"));
        }

        async private void MenuFlyoutItem_Click_70(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriELTjhL0bB7XSiaO"));
        }

        async private void MenuFlyoutItem_Click_71(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriUXDZ3pNnALV_guC"));
        }

        async private void MenuFlyoutItem_Click_72(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriFD3cj9x0BCy4qrS"));
        }

        async private void MenuFlyoutItem_Click_73(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriUbRw5QTvcGdkoIT"));
        }

        async private void MenuFlyoutItem_Click_74(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriGYe8nZz2HusypfB"));
        }

        async private void MenuFlyoutItem_Click_75(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriUfAfBYrGarhOYfI"));
        }

        async private void MenuFlyoutItem_Click_76(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPrh26Wb5u_hyCgqRK5"));
        }

        async private void MenuFlyoutItem_Click_77(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriHplLqsEpZfydPNv"));
        }

        async private void MenuFlyoutItem_Click_78(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriQCIkhsyPF76ODXV"));
        }

        async private void MenuFlyoutItem_Click_79(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriHsGX_mASnsV8uOp"));
        }

        async private void MenuFlyoutItem_Click_80(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriQHy9nC8SqpoX4av"));
        }

        async private void MenuFlyoutItem_Click_81(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriHwn3aJyU-JpgjfR"));
        }

        async private void MenuFlyoutItem_Click_82(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriQI0eaPtVPDXoBHT"));
        }
        async private void MenuFlyoutItem_Click_83(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriH3pVuR_nWxdKMDP"));
        }

        async private void MenuFlyoutItem_Click_84(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriQO2SHSuex-k0435"));
        }

        async private void MenuFlyoutItem_Click_85(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriH5oqq_E8cQvgtT8"));
        }

        async private void MenuFlyoutItem_Click_86(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriQTtOqhiJzpvylKn"));
        }

        async private void MenuFlyoutItem_Click_87(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPriH9P4bTwENxzFKYY"));
        }

        async private void MenuFlyoutItem_Click_88(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPrh2Z8moqi55807jy0"));

        
        }

        async private void MenuFlyoutItem_Click_89(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://1drv.ms/f/s!AiaDLQmq8IPrh2cV6Hzt8ay1l8lk"));
        }
    }
}
