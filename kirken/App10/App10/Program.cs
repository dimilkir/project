using System;

namespace App10
{
    class Program
    {
        static void Main(string[] args)
        {
            Owner owner = new Owner();
            Safe safe = new Safe();

            Thief thief = new Thief();
            thief.OpenSafe(safe, owner);

            Console.ReadKey();
        }
    }
}