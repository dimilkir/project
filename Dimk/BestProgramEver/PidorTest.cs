using System;

namespace BestProgramEver
{
     public class PidorTest
     {
        public string Test(string Name)
        {
            switch (Name)
            {
                case "1":
                    return "Не пидор!";
                case "2":
                case "3":
                    return "Пидор!";
                default:
                    return "Вводи данные правильно, Пидор!";
            }
        }
     }
}