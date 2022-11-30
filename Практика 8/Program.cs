using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_8
{
    class Program
    {
        static int recurs(int n)
        {
            if (n <= 15)
            {
                return n * n + 3 * n + 9;
            }
            else if (n > 15 && n % 3 == 0)
            {
                return recurs(n - 1) + n - 2;
            }
            else if (n > 15)
            {
                return recurs(n - 2) + n + 2;
            }
            else
            {
                return 404;
            }
        }
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int rez = (recurs(x));
            Console.WriteLine(rez);
            int k = 0;
            int count = 0;
            int flag = 0;
            for (int i = 1; i <= 1000; i++)
            {
                flag = 0;
                count = recurs(i);
                while (count > 0)
                {
                    if (((count % 10) % 2) != 0)
                    {
                        flag = 1;
                    }
                    count /= 10;
                }
                if (flag == 0)
                {
                    k++;
                    Console.WriteLine(recurs(i));
                }
            }
            Console.WriteLine(k);
            Console.ReadLine();
        }
    }
}
