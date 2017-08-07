using System;
using System.Windows.Forms;

namespace App9
{
    public partial class Form1 : Form
    {

        BananaFarmer farmer;

        public Form1()
        {
            InitializeComponent();
            farmer = new BananaFarmer((int)bananas.Value, 15);
        }

        private void bananas_ValueChanged(object sender, EventArgs e)
        {
            farmer.NumberOfBananas = (int)bananas.Value;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("I need {0} bags of bananas for Dimka!", farmer.BagsOfFeed.ToString("f3"), farmer.NumberOfBananas);
        }
    }
}
