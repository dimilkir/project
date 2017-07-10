using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace ConsoleApp1
{
    public class DimaAss
    {       
        public static void RunFuck() {
            String assNew = ".";
            String assOld = "O";
            String name = "   <--- Димкины Булочки";
             String[] fuckDimaAss = new String[] { "8===D (_" + assNew + "_)"+name, " 8===D(_" + assNew + "_)"+name, "  8===D_" + assNew + "_)"+name, "   8===D" + assNew + "_)"+name, "    8===D_)"+name, "     8==_)"+name, "      8=_)"+name, "       8_)"+name } ;
             String[] fuckDimaAss2 = new String[] { "8===D (_" + assOld + "_)"+name, " 8===D(_" + assOld + "_)"+name, "  8===D_" + assOld + "_)"+name, "   8===D" + assOld + "_)"+name } ;
             for (int i = 0; i < fuckDimaAss.Length; i++)
            {
            Console.WriteLine(fuckDimaAss[i]);
            Thread.Sleep(500);
            Console.Clear();
            }

             for (int i = 0; i < fuckDimaAss2.Length; i++){ fuckDimaAss[i] = fuckDimaAss2[i];}

             for (int i = fuckDimaAss.Length - 1; i > 0 ; i--)
            {
            Console.WriteLine(fuckDimaAss[i]);
            Thread.Sleep(500);
            Console.Clear();
            }
            
        }
        
    
    }
}
