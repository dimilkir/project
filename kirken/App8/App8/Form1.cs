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
            DinnerParty = new DinnerParty(
                (int)numericUpDown1.Value, healthyBox.Checked, fancyBox.Checked);
            DisplayDinnerPartyCost();
        }

        private void fancyBox_CheckedChanged(object sender, EventArgs e)
        {
            DinnerParty.FancyDecorations = fancyBox.Checked;
            DisplayDinnerPartyCost();
        }

        private void healthyBox_CheckedChanged(object sender, EventArgs e)
        {
            DinnerParty.HealthyOption = healthyBox.Checked;
            DisplayDinnerPartyCost();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            DinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }
        
        private void DisplayDinnerPartyCost()
        {
            decimal Cost = DinnerParty.Cost;
            costLabel.Text = Cost.ToString("c");
        }
    }
}
