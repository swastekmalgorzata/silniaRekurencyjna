using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace silniaRekurencyjna
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int x = 4;
            Console.WriteLine("silnia dla " + x + " to");
            Console.WriteLine(wyliczSilnie(x)); 
            Console.ReadKey();
        }
            static int wyliczSilnie(int n)
            {
                if (n <= 1) return 1;
                else return n * wyliczSilnie(n - 1);
                
            }
        
    }
}
