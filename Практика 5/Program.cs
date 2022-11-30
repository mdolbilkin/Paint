using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_5
{
    class Program
    {
        static int st(int n)
        {
            int number = n;
            int k = 0;
            while (n > 0)
            {

                number = n % 10;
                n = n / 10;
                if (number % 3 == 0) k += number;
            }
            return k;
        }
        static int sl(int x)
        {
            while (x > 100)
            {
                x /= 10;
            }
            return x % 10;
        }
        static int sv(int f)
        {
            int i, res = 0, k = 1, s = (int)f;
            while (s > 0)
            {
                if (s % 10 != 3)
                {
                    res = res + ((s % 10) * k);
                    k = k * 10;
                }
                s /= 10;
            }
            return res;
        }
        static int ba(int l)
        {
            int mx = l;
            int mn = 0;
            string res
            int l1 = int.Parse(Console.ReadLine());
            if (mx < l1)
            {
                mx = l1;
                mn = l;
            }
            for (int i =2; i <= l; i++)
            {
                if (mx % i == 0)
                {
                    if (!v(mn,i))
                    {
                        a += $"{i} ";
                    }
                }
            }
            return a;
        }
        static bool v(int n, int g)
        {
            int mx = n;
            if (mx < g)
            {
                mx = g;
            }
            bool tl = false;
            for (int i = 2; i < mx; i++)
            {
                if (g % i == 0)
                {
                    tl = true;
                }
            }
            return tl;
        }
        static int sk(int j)
        {
            int j1 = j;
            int count = 0;
            while (j1 > 0)
            {
                j1 /= 10;
                count += 1;
            }
            int w = j % 10;
            int w1 = j / (int)Math.Pow(10, count - 1);
            int w2 = j / 10 % (int)Math.Pow(10, count - 2);
            int res = (w * (int)Math.Pow(10, count - 2) + w2) * 10 + w1;
            return res;
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (st(a) == 0) Console.WriteLine("NO");
            else Console.WriteLine(st(a));
            int st1 = st(a);
            Console.WriteLine(st1);
            int sl1 = sl(a);
            Console.WriteLine(sl1);
            int sv1 = sv(a);
            Console.WriteLine(sv1);
            int sk1 = sk(a);
            Console.WriteLine(sk1); Console.WriteLine();
            int b = int.Parse(Console.ReadLine());
            string ba1 = ba(b);
            Console.WriteLine(ba1);
            Console.ReadLine();                 

            }
        }
    }

