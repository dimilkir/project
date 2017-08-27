using System;
using System.Windows.Forms;

namespace App7
{
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();

            nameBox.Items.Add("Димка");
            nameBox.Items.Add("Плюха");
            
            nameBox.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nameBox.Text != "")
            {
                Form1 mainForm = new Form1(nameBox.Text);
                mainForm.Show(this);
                this.Hide();
            }            
            else
            {
                MessageBox.Show("Выбери имя!", "Эй, парень!");
            }
        }
    }
}
