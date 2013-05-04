using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfCalc
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
        string[] input = new string[5];
        string[] tecken = new string[5];
        int resultat = 0;
        int index = 0;

        //Knapparna 0-9, sätter siffran i textboxen och in i en array
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            input[index] += "1";
            textBox1.Text += "1";
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            input[index] += "2";
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            input[index] += "3";
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            input[index] += "4";
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            input[index] += "5";
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            input[index] += "6";
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            input[index] += "7";
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            input[index] += "8";
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            input[index] += "9";
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            input[index] += "0";
            textBox1.Text += "0";
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
            //PlusKnappen
            textBox1.Text += " + ";
            tecken[index] += "+";
            index += 1;
        }

        private void button13_Click(object sender, RoutedEventArgs e)
        {
            //Likamed knappen
            resultat = Convert.ToInt32(input[0]);
            for (int i = 0; i < input.Count(); i++)
            {
                //Gör olika saker beroende på vilket tecken som man "valt"
                if (tecken[i] == "+")
                    resultat += Convert.ToInt32(input[i + 1]);
                else if (tecken[i] == "-")
                    resultat -= Convert.ToInt32(input[i + 1]);
                else if (tecken[i] == "/")
                    resultat /= Convert.ToInt32(input[i + 1]);
                else if (tecken[i] == "*")
                    resultat *= Convert.ToInt32(input[i + 1]);
            }
            textBox2.Text += resultat.ToString() + "\n";
        }

        private void button12_Click(object sender, RoutedEventArgs e)
        {
            //MinusKnappen
            textBox1.Text += " - ";
            tecken[index] += "-";
            index += 1;
        }

        private void button15_Click(object sender, RoutedEventArgs e)
        {
            //DelatKnappen
            textBox1.Text += " / ";
            tecken[index] += "/";
            index += 1;
        }

        private void button14_Click(object sender, RoutedEventArgs e)
        {
            //GångerKnappen
            textBox1.Text += " * ";
            tecken[index] += "*";
            index += 1;
        }

        private void button16_Click(object sender, RoutedEventArgs e)
        {
            //ClearKnapp
            textBox1.Clear();
            textBox2.Clear();
            index = 0;
            resultat = 0;
            input = new string[5];
            tecken = new string[5];
        }
    }
}
