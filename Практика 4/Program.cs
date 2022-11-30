using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_4
{
    class Program
    {
        static double min(double a, double b)
        {
            if (a < b) return a;
            else return b;
        }
        static double max(double a, double b, double c)
        {
            if(a > b)
            {
                if (a > c)
                {
                    return a;
                }
                else
                {
                    return c;
                }
            }
            else
            {
                if (b > c)
                {
                    return b;
                }
                else
                {
                    return c;
                }
            }
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double x = min(Math.Pow(max(a, Math.Abs(b + 1), a + 5.0), 1.0 / 2.0), min(a, b - max(a, -b, a * b))) - max(Math.Pow(a + 1, 1.0 / 2.0) / 2 + Math.Pow(a, 2), b + 5, a);
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
