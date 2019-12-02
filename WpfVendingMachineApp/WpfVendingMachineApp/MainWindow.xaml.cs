using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfVendingMachineApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            kiir_kevespenz();
            kiir_penzvissza();

        }

        #region metódusok

        public void kiir_kevespenz()
        {
            if (TextboxText.Text == "kevés pénz")
            {
                System.Threading.Thread.Sleep(3000);
                TextboxText.Text = "";
            }
        }

        public void kiir_penzvissza()
        {
            if (TextboxText.Text == "Pénz vissza!")
            {
                System.Threading.Thread.Sleep(3000);
                TextboxText.Text = "";
            }
        }
        #endregion

        #region változók

        int nulla = 0;
        int egy = 1;
        int ketto = 2;
        int harom = 3;
        int negy = 4;
        int ot = 5;
        int hat = 6;
        int het = 7;
        int nyolc = 8;
        int kilenc = 9;

        int tiz = 10;
        int husz = 20;
        int otven = 50;
        int szaz = 100;
        int ketszaz = 200;

        int bedobott_penz = 0;
        string beirt_kod = string.Empty;
        string visszajaro = string.Empty;

        bool ok = false;

        #endregion

        #region szám gombok

        //Delete
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextboxText.Text = "";
            TextboxText.Text = "Pénz vissza!";
            bedobott_penz = 0;
            ok = false;
        }
         
        //ok
        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            TextboxText.Text = "";
            if ( bedobott_penz < 50 )
            {
                TextboxText.Text = "kevés pénz";
                ok = false;
            }
            else
            {
                ok = true;
            }
        }

        //1
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(ok != false)
            {
                TextboxText.Text = TextboxText.Text + egy.ToString();
                beirt_kod = beirt_kod + TextboxText.Text;
            }
        }

        //2
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (ok != false)
            {
                TextboxText.Text = TextboxText.Text + ketto.ToString();
                beirt_kod = beirt_kod + TextboxText.Text;
            }
        }

        //3
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (ok != false)
            {
                TextboxText.Text = TextboxText.Text + harom.ToString();
                beirt_kod = beirt_kod + TextboxText.Text;
            }
        }

        //4
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (ok != false)
            {
                TextboxText.Text = TextboxText.Text + negy.ToString();
                beirt_kod = beirt_kod + TextboxText.Text;
            }
        }

        //5
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (ok != false)
            {
                TextboxText.Text = TextboxText.Text + ot.ToString();
                beirt_kod = beirt_kod + TextboxText.Text;
            }
        }

        //6
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (ok != false)
            {
                TextboxText.Text = TextboxText.Text + hat.ToString();
                beirt_kod = beirt_kod + TextboxText.Text;
            }
        }

        //7
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (ok != false)
            {
                TextboxText.Text = TextboxText.Text + het.ToString();
                beirt_kod = beirt_kod + TextboxText.Text;
            }
        }

        //8
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (ok != false)
            {
                TextboxText.Text = TextboxText.Text + nyolc.ToString();
                beirt_kod = beirt_kod + TextboxText.Text;
            }
        }

        //9
        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (ok != false)
            {
                TextboxText.Text = TextboxText.Text + kilenc.ToString();
                beirt_kod = beirt_kod + TextboxText.Text;
            }
        }

        //0
        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            if (ok != false)
            {
                TextboxText.Text = TextboxText.Text + nulla.ToString();
                beirt_kod = beirt_kod + TextboxText.Text;
            }
        }

        #endregion

        #region pénz gombok

        //5 ft
        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            if (ok == false)
            {
                bedobott_penz = bedobott_penz + ot;
                TextboxText.Text = Convert.ToString(bedobott_penz);
            }
        }

        //10 ft
        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            if (ok == false)
            {
                bedobott_penz = bedobott_penz + tiz;
                TextboxText.Text = Convert.ToString(bedobott_penz);
            }
        }

        //20 ft
        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            if (ok == false)
            {
                bedobott_penz = bedobott_penz + husz;
                TextboxText.Text = Convert.ToString(bedobott_penz);
            }
        }

        //50 ft
        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            if (ok == false)
            {
                bedobott_penz = bedobott_penz + otven;
                TextboxText.Text = Convert.ToString(bedobott_penz);
            }
        }

        //100 ft
        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            if (ok == false)
            {
                bedobott_penz = bedobott_penz + szaz;
                TextboxText.Text = Convert.ToString(bedobott_penz);
            }
        }

        //200 ft
        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            if (ok == false)
            {
                bedobott_penz = bedobott_penz + ketszaz;
                TextboxText.Text = Convert.ToString(bedobott_penz);
            }
        }


        #endregion

        
    }
}
