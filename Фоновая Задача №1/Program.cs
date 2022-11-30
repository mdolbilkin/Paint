using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фоновая_Задача__1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("a="); a = int.Parse(Console.ReadLine());
            Console.Write("b="); b = int.Parse(Console.ReadLine());
            Console.Write("c="); c = int.Parse(Console.ReadLine());
            double v = Math.Pow(a, b - c) + Math.Sin(a /(double)b) + Math.Pow((2 * a) + b - c, 1.0 / 3.0) - 2.6;
            Console.WriteLine($"{v:f2}");
            Console.ReadLine();


        }
    }
}
