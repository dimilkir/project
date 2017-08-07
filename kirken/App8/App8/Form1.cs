using System;
using System.Windows.Forms;

namespace App8
{
    public partial class Form1 : Form
    {

        DinnerParty DinnerParty;
        BirthdayParty BirthdayParty;

        public Form1()
        {
            InitializeComponent();
            DinnerParty = new DinnerParty(
                (int)numericUpDown1.Value, healthyBox.Checked, fancyBox.Checked);
            DisplayDinnerPartyCost();

            BirthdayParty = new BirthdayParty(
                (int)numberBithday.Value, fancyBirthday.Checked, cakeWriting.Text);
            DisplayBirthdayPartyCost();
        }

        //---

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

        //----------------

        private void numberBithday_ValueChanged(object sender, EventArgs e)
        {
            BirthdayParty.NumberOfPeople = (int)numberBithday.Value;
            DisplayBirthdayPartyCost();
        }

        private void fancyBirthday_CheckedChanged(object sender, EventArgs e)
        {
            BirthdayParty.FancyDecorations = fancyBirthday.Checked;
            DisplayBirthdayPartyCost();
        }

        private void cakeWriting_TextChanged(object sender, EventArgs e)
        {
            BirthdayParty.CakeWriting = cakeWriting.Text;
            DisplayBirthdayPartyCost();
        }

        private void DisplayBirthdayPartyCost()
        {
            tooLongLabel.Visible = BirthdayParty.CakeWritingTooLong;
            decimal cost = BirthdayParty.Cost;
            birthdayCost.Text = cost.ToString("c");
        }

    }
}
