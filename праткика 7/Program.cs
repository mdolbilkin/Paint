using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace праткика_7
{
    class Program { 
        static void PlusIMinus(ref int a, ref int b)
        {
            int k = a;
            a = b + a;
            b = k - b;
        }
        static void ChangeNum(ref int n, int m)
        {
            int k = n;
            int c = 0;
            int count = 0;
            while(k > 0)
            {
                c = c * 10 + k % 10;
                k /= 10;
            }
            while (c > 0)
            {
                if ((c % 10) % m == 0)
                {
                    count = count * 10 + m;
                }
                else if (c % 10 > m)
                {
                    count = count * 10 + 9;
                }
                else
                {
                    count = count * 10 + (c % 10);
                }
                c /= 10;
            }
            n = count;
            
        }
    
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            PlusIMinus(ref x1, ref x2);
            Console.WriteLine($"Сумма: {x1}");
            Console.WriteLine($"Разность: {x2}");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            ChangeNum(ref n, m);
            Console.WriteLine($"Преобразованное число: {n}");
            Console.ReadLine();
        }
    }
}
