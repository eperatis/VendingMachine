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
using System.IO;

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

        int otforint = 5;
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
        int zerocode = 15;
        int monticode = 17;
        int kavecode = 21;

        int cocacola = 200;
        int colazero = 250;
        int monti = 220;
        int kave = 150;

        string eladott_termek;

        #endregion

        #region funkció gombok

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
            //ha pénz kisebb mint 150 akkor visszadob
            if (ok == false & bedobott_penz < 150)
            {
                MessageBox.Show("Kevés pénz!\nDobj még be egy keveset :)", "Kevés!");
                ok = false;
            }

            if (ok == true & beirt_kod == 0)
            {
                string temp = TextboxText.Text;
                int x = 0;
                Int32.TryParse(temp, out x);
                beirt_kod = x;
            }

            if ((ok == true) & (beirt_kod != 0) & (beirt_kod != colacode) & (beirt_kod != zerocode) & (beirt_kod != monticode) & (beirt_kod != kavecode))
            {
                MessageBox.Show("Nincs ilyen termék kód!\nInkább visszaadom a pénzed!\nVisszajáró: " + bedobott_penz);
                ok = false;
                beirt_kod = 0;
                lefutott = false;
                TextboxText.Text = "";
                bedobott_penz = 0;
            }
            //Coca cola
            if ((ok == true) & (beirt_kod == colacode) & (beirt_kod != 0))
            {
                if(bedobott_penz < 200)
                {
                    MessageBox.Show("Kevés pénz!\nEz kevés lesz, inkább visszaadom :)\nVisszajáró:" + bedobott_penz, "Kevés!");
                    bedobott_penz = 0;
                    ok = false;
                    lefutott = false;
                    TextboxText.Text = "";
                }
                else if (coladb.Text == "0")
                {
                    MessageBox.Show("Sajnálom, de a termék elfogyott!\nInkább visszaadom a pénzed :)\nVisszajáró:" + bedobott_penz, "Out of stock!");
                    bedobott_penz = 0;
                    ok = false;
                    lefutott = false;
                    TextboxText.Text = "";
                    beirt_kod = 0;
                }
                else
                {
                    eladott_termek = DateTime.Now.ToString() + " Coca cola " + cocacola + "Ft";
                    File.AppendAllText("eladasok.txt", eladott_termek + Environment.NewLine);
                    visszajaro = bedobott_penz - cocacola;
                    MessageBox.Show("Visszajáró:" + visszajaro + "\nÚjra vásárláshoz, dobj be egy kis aprót :D");
                    ok = false;
                    lefutott = false;
                    bedobott_penz = 0;
                    TextboxText.Text = "";
                    visszajaro = 0;
                    beirt_kod = 0;
                    string temp = coladb.Text;
                    int x = 0;
                    Int32.TryParse(temp, out x);
                    x = x - 1;
                    coladb.Text = Convert.ToString(x);
                }
            }

            //Coca cola Zero
            if ((ok == true) & (beirt_kod == zerocode) & (beirt_kod != 0))
            {
                if (bedobott_penz < 250)
                {
                    MessageBox.Show("Kevés pénz!\nEz kevés lesz, inkább visszaadom :)\nVisszajáró:" + bedobott_penz, "Kevés!");
                    bedobott_penz = 0;
                    ok = false;
                    lefutott = false;
                    TextboxText.Text = "";
                }
                else if (zerodb.Text == "0")
                {
                    MessageBox.Show("Sajnálom, de a termék elfogyott!\nInkább visszaadom a pénzed :)\nVisszajáró:" + bedobott_penz, "Out of stock!");
                    bedobott_penz = 0;
                    ok = false;
                    lefutott = false;
                    TextboxText.Text = "";
                    beirt_kod = 0;
                }
                else
                {
                    eladott_termek = DateTime.Now.ToString() + " Zero cola " + colazero + "Ft";
                    File.AppendAllText("eladasok.txt", eladott_termek + Environment.NewLine);
                    visszajaro = bedobott_penz - colazero;
                    MessageBox.Show("Visszajáró:" + visszajaro + "\nÚjra vásárláshoz, dobj be egy kis aprót :D");
                    ok = false;
                    lefutott = false;
                    bedobott_penz = 0;
                    TextboxText.Text = "";
                    visszajaro = 0;
                    beirt_kod = 0;
                    string temp = zerodb.Text;
                    int x = 0;
                    Int32.TryParse(temp, out x);
                    x = x - 1;
                    zerodb.Text = Convert.ToString(x);
                }
            }

            //Mountaind dew
            if ((ok == true) & (beirt_kod == monticode) & (beirt_kod != 0))
            {
                if (bedobott_penz < 220)
                {
                    MessageBox.Show("Kevés pénz!\nEz kevés lesz, inkább visszaadom :)\nVisszajáró:" + bedobott_penz, "Kevés!");
                    bedobott_penz = 0;
                    ok = false;
                    lefutott = false;
                    TextboxText.Text = "";
                }
                else if (montidb.Text == "0")
                {
                    MessageBox.Show("Sajnálom, de a termék elfogyott!\nInkább visszaadom a pénzed :)\nVisszajáró:" + bedobott_penz, "Out of stock!");
                    bedobott_penz = 0;
                    ok = false;
                    lefutott = false;
                    TextboxText.Text = "";
                    beirt_kod = 0;
                }
                else
                {
                    eladott_termek = DateTime.Now.ToString() + " Mountain dew " + monti + "Ft";
                    File.AppendAllText("eladasok.txt", eladott_termek + Environment.NewLine);
                    visszajaro = bedobott_penz - monti;
                    MessageBox.Show("Visszajáró:" + visszajaro + "\nÚjra vásárláshoz, dobj be egy kis aprót :D");
                    ok = false;
                    lefutott = false;
                    bedobott_penz = 0;
                    TextboxText.Text = "";
                    visszajaro = 0;
                    beirt_kod = 0;
                    string temp = montidb.Text;
                    int x = 0;
                    Int32.TryParse(temp, out x);
                    x = x - 1;
                    montidb.Text = Convert.ToString(x);
                }
            }

            //Presso kave
            if ((ok == true) & (beirt_kod == kavecode) & (beirt_kod != 0))
            {
                if (bedobott_penz < 150)
                {
                    MessageBox.Show("Kevés pénz!\nEz kevés lesz, inkább visszaadom :)\nVisszajáró:" + bedobott_penz, "Kevés!");
                    bedobott_penz = 0;
                    ok = false;
                    lefutott = false;
                    TextboxText.Text = "";
                }
                else if (pressodb.Text == "0")
                {
                    MessageBox.Show("Sajnálom, de a termék elfogyott!\nInkább visszaadom a pénzed :)\nVisszajáró:" + bedobott_penz, "Out of stock!");
                    bedobott_penz = 0;
                    ok = false;
                    lefutott = false;
                    TextboxText.Text = "";
                    beirt_kod = 0;
                }
                else
                {
                    eladott_termek = DateTime.Now.ToString() + " Starbucks presso kávé " + kave + "Ft";
                    File.AppendAllText("eladasok.txt", eladott_termek + Environment.NewLine);
                    visszajaro = bedobott_penz - kave;
                    MessageBox.Show("Visszajáró:" + visszajaro + "\nÚjra vásárláshoz, dobj be egy kis aprót :D");
                    ok = false;
                    lefutott = false;
                    bedobott_penz = 0;
                    TextboxText.Text = "";
                    visszajaro = 0;
                    beirt_kod = 0;
                    string temp = pressodb.Text;
                    int x = 0;
                    Int32.TryParse(temp, out x);
                    x = x - 1;
                    pressodb.Text = Convert.ToString(x);
                }
            }

            //ha pénz nagyobb akkor mehet tovább
            if (ok == false & bedobott_penz >= 150 & lefutott == false)
            {
                TextboxText.Text = "";
                MessageBox.Show("Pénz elfogadva!\nÜsd be a termék kódját!","Vásárlás!");
                ok = true;
                lefutott = true;
            }
        }

        #endregion

        #region szám gombok

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
                bedobott_penz = bedobott_penz + otforint;
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
