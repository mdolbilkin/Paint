using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_6
{
    class Program
    {
        static int nbit(int x, int n)
        {
            int m = 1 << n;
            if ((x & m) != 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        static void k(int p)
        {
            uint mask = 0x80000000;
            for(int i = 0; i < 32; i++)
            {
                if ((mask & p) == mask)
                {
                    Console.Write(1);
                    mask = mask >> 1;
                }
                else
                {
                    Console.Write(0);
                    mask = mask >> 1;
                }
            }
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int rez = nbit(a, b);
            //номер 3
            k(a);
            Console.WriteLine();
            //номер 2
            Console.WriteLine(rez);
            Console.ReadLine();
        }
    }
}
