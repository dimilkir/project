using System;

namespace App10
{
    class Thief : Locksmith
    {
        Jewels stolenJewels = null;
        public void ReturnContents(Jewels safeContents, Owner owner)
        {
            stolenJewels = safeContents;
            Console.WriteLine("Stealing jewels! @" + stolenJewels.Sparkle());
        }
    }
}
