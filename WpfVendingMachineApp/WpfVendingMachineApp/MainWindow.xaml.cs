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
        }

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
        int beirt_kod = 0;
        int visszajaro = 0;

        bool ok = false;
        bool lefutott = false;

        int colacode = 13;
        string zerocode = "15";
        string monticode = "17";
        string kavecode = "21";

        int cocacola = 200;
        int colazero = 250;
        int monti = 220;
        int kave = 150;

        #endregion

        #region szám gombok

        //Delete
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextboxText.Text = "0";
            MessageBox.Show("Visszajáró: " + Convert.ToString(bedobott_penz),"Delete");
            bedobott_penz = 0;
            ok = false;
            lefutott = false;
        }
         
        //ok
        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            if (ok == true & beirt_kod == 0)
            {
                string temp = TextboxText.Text;
                int x = 0;
                Int32.TryParse(temp, out x);
                beirt_kod = x;
            }
            if ((ok == true) & (beirt_kod == colacode) & (beirt_kod != 0))
            {
                visszajaro = bedobott_penz - cocacola;
                MessageBox.Show("Visszajáró:" + visszajaro);
                ok = false;
                lefutott = false;
            }

            //ha pénz kisebb mint 150 akkor visszadob
            if (ok == false & bedobott_penz < 150 )
            {
                MessageBox.Show("Kevés pénz!\nDobj még be egy keveset :)", "Kevés!");
                ok = false;
            }
            //ha pénz nagyobb akkor mehet tovább
            if(ok == false & bedobott_penz >= 150 & lefutott == false)
            {
                TextboxText.Text = "";
                MessageBox.Show("Pénz elfogadva!\nÜsd be a termék kódját!","Kód!");
                ok = true;
                lefutott = true;
            }
            
            
            
        }

        //1
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(ok != false)
            {
                TextboxText.Text = TextboxText.Text + egy.ToString();
            }
        }

        //2
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (ok != false)
            {
                TextboxText.Text = TextboxText.Text + ketto.ToString();
            }
        }

        //3
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (ok != false)
            {
                TextboxText.Text = TextboxText.Text + harom.ToString();
            }
        }

        //4
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (ok != false)
            {
                TextboxText.Text = TextboxText.Text + negy.ToString();
            }
        }

        //5
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (ok != false)
            {
                TextboxText.Text = TextboxText.Text + ot.ToString();
            }
        }

        //6
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (ok != false)
            {
                TextboxText.Text = TextboxText.Text + hat.ToString();
            }
        }

        //7
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (ok != false)
            {
                TextboxText.Text = TextboxText.Text + het.ToString();
            }
        }

        //8
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (ok != false)
            {
                TextboxText.Text = TextboxText.Text + nyolc.ToString();
            }
        }

        //9
        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (ok != false)
            {
                TextboxText.Text = TextboxText.Text + kilenc.ToString();
            }
        }

        //0
        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            if (ok != false)
            {
                TextboxText.Text = TextboxText.Text + nulla.ToString();
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
