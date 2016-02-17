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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1_1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        public string Buylist;
        public bool Mibool;
        public bool Bubool;
        public bool Bebool;
        public bool Chibool;
        public bool Lebool;
        
        private void BuyClick(object sender, RoutedEventArgs e)
        {
            Buylist = "";
            if (Mibool == true) Buylist += "Milk";
            if (Bubool == true) Buylist += ", Butter";
            if (Bebool == true) Buylist += ", Beer";
            if (Chibool == true) Buylist += ", Chicken";
            if (Lebool == true) Buylist += ", Lemonade";
            Buylist += ".";
            
            textBlock.Text = "";
            textBlock.Text = Buylist;
        }
        private void Mchecked(object sender, RoutedEventArgs e)
        {
            Mibool = true;
        }
        private void Muchecked(object sender, RoutedEventArgs e)
        {
            Mibool = false;
        }
        private void Bchecked(object sender, RoutedEventArgs e)
        {
            Bubool = true;
        }
        private void Buchecked(object sender, RoutedEventArgs e)
        {
            Bubool = false;
        }

        private void Bechecked(object sender, RoutedEventArgs e)
        {
            Bebool = true;
        }

        private void Beuchecked(object sender, RoutedEventArgs e)
        {
            Bebool = false;
        }

        private void Chichecked(object sender, RoutedEventArgs e)
        {
            Chibool = true;
        }

        private void Chiuchecked(object sender, RoutedEventArgs e)
        {
            Chibool = false;
        }

        private void Lechecked(object sender, RoutedEventArgs e)
        {
            Lebool = true;
        }

        private void Leuchecked(object sender, RoutedEventArgs e)
        {
            Lebool = false;
        }
    }
}
