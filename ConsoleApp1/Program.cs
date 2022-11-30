using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите координату x: "); double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату y: "); double y = Convert.ToDouble(Console.ReadLine());
            double res;
            res = (double)y / Math.Pow((double)x, 2);
            if (Math.Pow(x, 2) + Math.Pow(y, 2) <= 4 * 4) Console.WriteLine(Math.Pow(Math.Abs(y + x), 1.0 / 2.0) - 1.0);
            else if (y >= 4)
            {
                
                Console.WriteLine($"{res:f2}");
            }
            else if (y <= -4)
            {
                Console.WriteLine($"{res:f2}");
            }
            else if (x < 0)
            {
                Console.WriteLine($"{res:f2}");
            }
            else if (x > 4)
            {
                Console.WriteLine($"{res:f2}");
            }
                     
            
            else
            {
                res = Math.Pow(Math.Abs(y + x), 1.0 / 2.0) - 1.0;
                Console.WriteLine($"{res:f2}");
            }
                Console.ReadLine();
                
            
        }
    }
}
