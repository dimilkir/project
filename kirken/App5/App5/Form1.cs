using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuMaker menu = new MenuMaker() { Randomizer = new Random() };

            string result = "";

            for (int i=0; i < counter.Value; i++)
            {
                result += (i==0 ? "" : "\n") + menu.GetAction();
            }

            MessageBox.Show(result);
        }
    }
}
