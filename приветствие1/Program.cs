using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace приветствие1
{
    class Program
    {
        static int pow(int x, int n)
        {
            if (n == 0) return 1;
            return pow(x, n - 1) * x;
        }
        static void Main(string[] args)
        {
            //byte a = 11;
            //byte b = 100;
            //Console.WriteLine(a & b); Console.WriteLine(a | b); Console.WriteLine(a >> 1); Console.WriteLine(b << 1); Console.WriteLine(a ^ b); Console.WriteLine(~a); Console.WriteLine(~b);
            int x = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(pow(x, n));
            Console.ReadLine();
        }
    }
}
