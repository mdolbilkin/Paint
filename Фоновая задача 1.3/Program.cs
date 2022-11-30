using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фоновая_задача_1._3
{
    class Program
    {
        static int vod(int n)
        {
            int m = int.Parse(Console.ReadLine());
            int pred = 0;
            for (int i = 1; i < n; i++)
            {
                int k = int.Parse(Console.ReadLine());
                if ((k + pred) > m)
                {
                    m = k + pred;
                    pred = k;
                }
                else
                {
                    pred = k;
                }
            }
            return m;
        }
        static void Main(string[] args)
        {
            int n = vod(int.Parse(Console.ReadLine()));
            Console.WriteLine(n);
            Console.ReadLine();
        }
    }
}
