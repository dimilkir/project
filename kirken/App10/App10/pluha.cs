using System;

namespace App10
{
    class Pluha : KirkenBro
    {
        override 
            public void GetBananas(Bananas bananas, Dimka dimka)
        {
            Console.WriteLine("Плюха кинул бананом в Димку! @" + bananas.BananaSmashing());
        }
    }
}