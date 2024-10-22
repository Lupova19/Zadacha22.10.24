using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zadacha
{
    public class MyClass
    {
        private static string k;
        private static int l;

        static void Run()
        {
            Console.WriteLine("Parvata dashterna nishka zapochna....");
            for (int k = 0; k <= 2; k++)
            {
                Console.WriteLine("Dashterna nishka:" + k);
                Thread.Sleep(500);
            }
            Console.WriteLine("Parva dashterna nishka prikluchi!");
        }
        static void Run2()
        {
            Console.WriteLine("Vtora dashterna nishka zapochna....");
            for (int l = 0; l <= 2; l++)
            {
                Console.WriteLine("Dashterna nishka:" + l);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Vtora dashterna nishka prikluchi!");
        }

        static void Main()
        {
            Console.WriteLine("Glavnata nishka e startirana...");
            Thread t = new Thread(Run);
            t.Start();
            Thread d = new Thread(Run2);
            d.Start();
        }
    }
}
