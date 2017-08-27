using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace App3
{
    public partial class Form1 : Form
    {

        Guy pluha;
        Guy limon;

        int bananas = 10;

        public Form1()
        {
            InitializeComponent();

            pluha = new Guy();
            pluha.init("Плюха", 0);

            limon = new Guy();
            limon.init("Лимон", 0);

            updateHead();
        }

        public void updateHead()
        {
            pluhaLabel.Text = "Бананов у Плюхи: " + pluha.howMuchCash();
            limonLabel.Text = "Бананов словил на лицо Лимон: " + limon.howMuchCash();
            this.Text = "Бананов всего: " + bananas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pluha.howMuchCash() >= 1)
            {
                pluha.setCash(pluha.howMuchCash() - pluha.GiveCash(1));
                limon.ReceiveCash(1);
                updateHead();
                playSound(2);
            } else
            {
                playSound(3);
                MessageBox.Show("Не хватает бананов!", "ВОУ ВОУ!");
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bananas >= 1)
            {
                bananas -= pluha.ReceiveCash(1);
                updateHead();
                playSound(1);
            } else
            {
                playSound(3);
                MessageBox.Show("Не хватает бананов!", "ВОУ ВОУ!");
            }
        }

        private void playSound(int stream)
        {
            SoundPlayer player = new SoundPlayer();
            switch (stream)
            {
                case 1:
                    player.Stream = Properties.Resources.smb_coin;
                    break;
                case 2:
                    player.Stream = Properties.Resources.smb_jump_small;
                    break;
                default:
                    player.Stream = Properties.Resources.WHY;
                    break;
            }
            player.Play();
        }
    }
}
