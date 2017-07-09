using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp;
            do{
                Console.Clear();
                Console.WriteLine("Пидор Димка или нет?");
                Console.WriteLine("1. Димка Пидор, я согласен");
                Console.WriteLine("2. Нужны доказательства");
                inp = Console.ReadLine().ToString();

            if (inp != "1")
                {
                    Console.Clear();
                    DimaAss Zadv = new DimaAss();
                    DimaAss.RunFuck();
                    Console.WriteLine("Доказательства на лицо, Димка Пидор!");
                    inp = Console.ReadLine().ToString();
                    
                }
            
            }  while (inp != "1");        
        }
    }
}
