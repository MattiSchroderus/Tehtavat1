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

namespace App1_3
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
        
        public string Choice;
        public int RowNmbr=1;
        public int Drawamount=20;
        private void Drawbutton_draw(object sender, RoutedEventArgs e)
        {
            Choice = comboBox1.SelectedValue.ToString();

            
            
            switch (Choice)
            {
                case "Lotto":

                   
                        Lotto lotto = new Lotto(7,39,"");

                    while (RowNmbr < Drawamount)
                    {
                        lotto.PerusLotto();
                        textBlock1.Text += "Row "+RowNmbr+ ":  " + lotto.Result + "\n";
                        RowNmbr++;
                        
      
                    }
                   
                    break;

                case "Viking":
                    Lotto viking = new Lotto(7, 39, "");
                    while (RowNmbr < Drawamount)
                    {
                        viking.PerusLotto();
                        textBlock1.Text += "Row " + RowNmbr + ": " + viking.Result + "\n";
                        RowNmbr++;
                    }
                    break;

                case "EuroJP":
                    Lotto euro = new Lotto(7, 39, "");
                    while (RowNmbr < Drawamount)
                    {
                        euro.PerusLotto();
                        textBlock1.Text += "Row " + RowNmbr + ": " + euro.Result + "\n";
                        RowNmbr++;
                    }
                    break;


                default:
                    break;
            }



            

        }
    }
}
