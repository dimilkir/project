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

namespace App1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string name = "Плюха";
            int x = 3;
            x = x * 17;
            double d = Math.PI / 2;
            myLabel.Text = "name is " + name + "\nx is " + x + "\nd is " + d;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            string x = "лох";
            if (x=="лох")
            {
                myLabel.Text = "Плюха лох";
            }
            else
            {
                myLabel.Text = "Плюха не лох";
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            int someValue = 3;
            string name = "Плюха";
            if ((someValue == 3) && (name == "Плюха"))
            {
                myLabel.Text = "x is 3 and Плюха лох";
            }
            myLabel.Text = "this line runs no matter what";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            int cunt = 0;
            while (cunt < 10)
            {
                cunt = cunt + 1;
            }
            for (int i = 0; i < 5; i++)
            {
                cunt = cunt - 1;
            }
            myLabel.Text = "Плюха лох, а переменная равна " + cunt;
        }
    }
}
