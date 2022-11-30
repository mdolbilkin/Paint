using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фоновая_Задача_2._1
{
    class Program
    {
        static int m(int x1)
        {
            int k = 0;
            int mask = 1;
            for (int i = 0; i < 32; i++)
            {
                if ((x1 & mask) == 1) k += 1;
                x1 = x1 >> 1;
            }
            return k;
        }
        static void OutPut(int x2)
        {
            uint mask = 0x8000;
            int b = 0;
            for (int i = 0; i < 16; i++)
            {
                if (b == 4)
                {
                    Console.Write(" ");
                    b = 0;
                }
                if ((mask & x2) == 0)
                {
                    Console.Write(0);
                    b += 1;
                }
                else
                {
                    Console.Write(1);
                    b += 1;
                }
                mask = mask >> 1;

            }
        }
        static uint Summa(ushort x, ushort n)
        {
            uint mask = 0x80000000;
            uint res = n;
            res = res << 16;
            res += x;
            return res;
        }
        static void Main(string[] args)
        {
            int l = int.Parse(Console.ReadLine());
            int result = m(l);
            Console.WriteLine(result);
            int n = int.Parse(Console.ReadLine());
            OutPut(n);
            Console.WriteLine();
            ushort x1 = ushort.Parse(Console.ReadLine());
            ushort x2 = ushort.Parse(Console.ReadLine());
            uint rez = Summa(x1, x2);
            Console.WriteLine(rez);
            Console.ReadLine();
        }
    }  
        
    }
