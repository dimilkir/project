
using System;

namespace App10
{
    class Dimka
    {
        Bananas bananas;      
        public void ReceiveBananas(Bananas bananas)
        {
            this.bananas = bananas;
            Console.WriteLine("Димка кушает банан! @" + bananas.BananaEating());
        }
    }
}