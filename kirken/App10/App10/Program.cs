using System;

namespace App10
{
    class Program
    {
        static void Main(string[] args)
        {
            Dimka dimka = new Dimka();
            BananaBox bananaBox = new BananaBox();

            Pluha pluha = new Pluha();
            pluha.OpenBananaBox(bananaBox, dimka);

            Console.ReadKey();
        }
    }
}