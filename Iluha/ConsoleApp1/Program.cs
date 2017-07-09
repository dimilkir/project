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
                Console.WriteLine("Димка Пидор, я согласен = жми 1");
                Console.WriteLine("Нужны доказательства = press any key");
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
