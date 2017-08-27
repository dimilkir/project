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
            farmer.NumberOfBananas = check((int)bananas.Value) ? (int)bananas.Value : (int)bananas.Value;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            resultLabel.Text = string.Format("I need {0} bags of bananas for Dimka!", farmer.BagsOfFeed.ToString("f3"), farmer.NumberOfBananas);
            Console.WriteLine(resultLabel.Text);
        }

        bool check(int Value)
        {
            if (Value == (Properties.Resources._3.Size.Height - Properties.Resources._3.Size.Width) * 3) {
                MessageBox.Show("\u041E\u0422\u0421\u041E\u0421\u0418\u0020\u0423\u0020\u0422\u0420\u0410\u041A\u0422\u041E\u0420\u0418\u0421\u0422\u0410\u0021\u0021\u0021");
            }
            return Value > bananas.Minimum;
        }
    }
}