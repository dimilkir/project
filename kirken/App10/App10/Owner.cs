
using System;

namespace App10
{
    class Owner
    {
        Jewels returnedContens;
        
        public void ReceiveContens(Jewels safeContents)
        {
            returnedContens = safeContents;
            Console.WriteLine("Jewels returned! @" + safeContents.Sparkle());
        }
    }
}
