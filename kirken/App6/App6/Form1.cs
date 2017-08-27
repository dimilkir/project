using System;
using System.IO;
using System.Media;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace App6
{
    public partial class Form1 : Form
    {

        Random random = new Random();
        Stats stats = new Stats();

        private SoundPlayer player = new SoundPlayer();

        public Form1()
        {
            InitializeComponent();

            string fileName = Path.GetTempFileName();
            File.WriteAllBytes(fileName, Properties.Resources.rusFont);
            PrivateFontCollection pfc = new System.Drawing.Text.PrivateFontCollection();
            pfc.AddFontFile(fileName);

            Font myFont = new Font(pfc.Families[0], 72f, FontStyle.Regular, GraphicsUnit.Point, 0);

            listBox1.Font = myFont;
            playSound(0);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            difficultyProgressBar.Focus();

            listBox1.Items.Add((Keys)random.Next(65, 90));
            if (listBox1.Items.Count > 7)
            {
                listBox1.Items.Clear();
                listBox1.ForeColor = Color.FromArgb(255, 0, 0);
                listBox1.Items.Add("ПОТРАЧЕНО");
                playSound(1);
                timer1.Stop();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!timer1.Enabled)
            {
                stats.Reset();
                listBox1.Items.Clear();
                listBox1.ForeColor = Color.FromArgb(0, 255, 0);
                timer1.Interval = 800;
                timer1.Start();
                playSound(0);
            }
            else
            {
                if (listBox1.Items.Contains(e.KeyCode))
                {
                    listBox1.Items.Remove(e.KeyCode);
                    if (timer1.Interval > 400) timer1.Interval -= 10;
                    if (timer1.Interval > 250) timer1.Interval -= 7;
                    if (timer1.Interval > 200) timer1.Interval -= 2;
                    difficultyProgressBar.Value = 800 - timer1.Interval;

                    stats.Update(true);
                }
                else
                {
                    stats.Update(false);
                }
            }
            
            correctLabel.Text  = "Ништяк: "  + stats.Correct;
            missedLabel.Text   = "Зашквар: " + stats.Missed;
            totalLabel.Text    = "Скопом: "  + stats.Total;
            accuracyLabel.Text = "Крутота: " + stats.Accuracy + "%";

        }

        private void playSound(int stream)
        {
            switch (stream)
            {
                case 1:

                    player.Stream = Properties.Resources.wasted;
                    player.Play();

                    break;

                default:
                    
                    player.Stream = Properties.Resources.theme;
                    player.Play();

                    break;
            }            
        }
    }

}
