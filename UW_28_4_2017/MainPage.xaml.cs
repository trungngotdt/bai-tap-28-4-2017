using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UW_28_4_2017
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int debug = 0;
        public MainPage()
        {
            this.InitializeComponent();
            MyFrame.Navigate(typeof(Page1));
        }

        private void btn_home_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(Page1));
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            if (MyFrame.CanGoBack)
            {
                MyFrame.GoBack();
            }
        }

        private void btn_forward_Click(object sender, RoutedEventArgs e)
        {
            if (MyFrame.CanGoForward)
            {
                MyFrame.GoForward();
            }
        }

        private void Btn_Navigation_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Page1));
        }


        private void Hplb_Page1_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(Page1));
        }

        private void Btn_Menu_Click(object sender, RoutedEventArgs e)
        {
            Spv_Hamburger.IsPaneOpen = !Spv_Hamburger.IsPaneOpen;
            debug = 0;
        }
        
        
        private void Lst_hamburger_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (Lsti_home.IsSelected)
            {
                MyFrame.Navigate(typeof(Page2));
                Spv_Hamburger.IsPaneOpen = !Spv_Hamburger.IsPaneOpen;
            }
            if (Lsti_page2.IsSelected)
            {
                MyFrame.Navigate(typeof(Page3));
                Spv_Hamburger.IsPaneOpen = !Spv_Hamburger.IsPaneOpen;
            }
            if (MyFrame.CanGoBack)
            {
                Splv_Control.IsPaneOpen = true;
            }
            else
            {
                Splv_Control.IsPaneOpen = false;
            }

        }

        private void Btn_ComeBack_Click(object sender, RoutedEventArgs e)
        {
            if (MyFrame.CanGoBack)
            {
                MyFrame.GoBack();
            }
            if (MyFrame.CanGoBack)
            {
                Splv_Control.IsPaneOpen = true;
            }
            else
            {
                Splv_Control.IsPaneOpen = false;
            }
        }
    }
}
