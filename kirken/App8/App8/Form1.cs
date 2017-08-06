using System;
using System.Windows.Forms;

namespace App8
{
    public partial class Form1 : Form
    {

        DinnerParty DinnerParty;

        public Form1()
        {
            InitializeComponent();

            DinnerParty = new DinnerParty();
            DinnerParty.SetPartyOptions(5, fancyBox.Checked);
            DinnerParty.SetHealthyOption(healthyBox.Checked);
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            DinnerParty.SetPartyOptions((int)numericUpDown1.Value, fancyBox.Checked);
            decimal Cost = DinnerParty.CalculateCost(healthyBox.Checked);
            costLabel.Text = Cost.ToString("c");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            DisplayDinnerPartyCost();
        }

        private void fancyBox_CheckedChanged(object sender, EventArgs e)
        {
            DisplayDinnerPartyCost();
        }

        private void healthyBox_CheckedChanged(object sender, EventArgs e)
        {
            DisplayDinnerPartyCost();
        }
    }
}
