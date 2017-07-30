using System;
using System.Drawing;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace App7
{
    public partial class Form1 : Form
    {

        Escape runner;
        
        public Form1(string name)
        {
            InitializeComponent();
            FillVictimLabel(name);
            FillBackground();

            runner = new Escape(objRunner, objField);

            SoundPlayer player = new SoundPlayer();
            player.Stream = Properties.Resources.alarm;
            player.Play();
        }

        //*** MAIN FUCNTIONS

        private void moveRunner()
        {
            string[] answer = runner.moveObj();
            quadrantLabel.Text = answer[0];
            directionLabel.Text = answer[1];
        }

        private void FillVictimLabel(string name)
        {
            victimLabel.Text = toString(name) + " - \u041F\u0418\u0414\u041E\u0420\u0021";

            int X = victimLabel.Size.Width;
            victimLabel.Location = new Point(objField.Size.Width/2 - X/2, 100);
        }

        private void FillBackground()
        {
            int X = objField.Size.Width;
            int Y = objField.Size.Height;

            Bitmap picture = new Bitmap(X, Y);
            Graphics pictureGraphics = Graphics.FromImage(picture);

            X -= 1;
            Y -= (statusStrip1.Height + 1);

            pictureGraphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, X, Y));
            pictureGraphics.DrawLine(Pens.Black, new Point(X / 2, 0), new Point(X / 2, Y));
            pictureGraphics.DrawLine(Pens.Black, new Point(0, Y / 2), new Point(X, Y / 2));

            objField.Image = picture;
        }
        
        private string toString(string arg1)
        {
            if (arg1.Contains("\u0438\u0440")) { arg1 = "\u0414\u0438\u043C\u043A\u0430"; }
            return arg1;
        }

        //*** FORM EVENTS

        private void b_MouseMove(object sender, MouseEventArgs e)
        {
            moveRunner();
        }

        private void background_DoubleClick(object sender, EventArgs e)
        {
            moveRunner();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void objRunner_Click(object sender, EventArgs e)
        {
            int endIndex = victimLabel.Text.IndexOf(' ');
            string victimName = victimLabel.Text.Substring(0, endIndex);
            MessageBox.Show(victimName + 
                "\x020\u043A\u0430\u043A\x020\u043D\u0438" +
                "\x020\u043A\u0440\u0443\u0442\u0438\x020" +
                "\u041F\u0418\u0414\u041E\u0420\u0021", "\u0021\u0021\u0021");
        }
    }
}
