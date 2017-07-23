using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App3
{
    class Guy
    {
        private string Name;
        private int Cash;

        public void init(string name, int cash)
        {
            Name = name;
            Cash = cash;
        }

        public int howMuchCash()
        {
            return Cash;
        }

        public void setCash(int sum)
        {
            Cash = sum;
        }

        public int GiveCash(int amount) {
            if (amount <= Cash && amount > 0) {
                Cash -= amount;
                return amount;
            } else {
                return 0;
            }
        }

        public int ReceiveCash(int amount) {
            if (amount > 0) {
                Cash += amount;
                return amount;
            } else  {
                return 0;
            }

        }
    }
}
