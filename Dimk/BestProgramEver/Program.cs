using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestProgramEver
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            do
            {
                Console.Clear();
                Console.WriteLine("Проверь пидор ты или нет. Кто ты?:");
                Console.WriteLine("1. Димк");
                Console.WriteLine("2. Плюха");
                Console.WriteLine("3. Кирк");
                Console.WriteLine("4. Выход");
                command = Console.ReadLine().ToString();
                if (command != "4")
                {
                    Console.Clear();
                    PidorTest PTest = new PidorTest();
                    Console.WriteLine(PTest.Test(command));
                    Console.WriteLine();
                    Console.WriteLine("Еще раз? Или нажми 4, чтобы выйти");
                    command = Console.ReadLine().ToString();
                }
            } while (command != "4");
        }
    }
}
