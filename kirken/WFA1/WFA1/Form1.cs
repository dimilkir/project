using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA1
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (true)
            {

                button1.Text = "ОТДАЙ ДУШУ!";
                button1.ForeColor = Color.Yellow;

                for (int c = 0; c <= 253; c++)
                {
                    this.BackColor = Color.FromArgb(c, 255 - c, c);
                    button1.BackColor = Color.FromArgb(255 - c, c, 255 - c);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(3);
                }

                for (int c = 254; c >= 0; c--)
                {
                    this.BackColor = Color.FromArgb(c, 255 - c, c);
                    button1.BackColor = Color.FromArgb(255 - c, c, 255 - c);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(3);
                }
            }
        }
    }
}
