using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App4
{
    public partial class Form1 : Form
    {
        int begin;
        int end;

        double nakidano;
        double bananaPrice = 8.87; //средняя цена одного банана при среднем весе 150 грамм
        double money;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            begin = (int)start.Value;
            end = (int)finish.Value;

            if (end > begin)
            {
                MessageBox.Show("Нех пиздеть мне тут!", "Э, йоба!");
            }
            else
            {
                nakidano = begin - end;
                money = nakidano * bananaPrice;
                resultLabel.Text = money + " руб.";
            }
        }
    }
}
