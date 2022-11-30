using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //№1
            Console.WriteLine($"\t\t\tТАБЛИЦА УМНОЖЕНИЯ");
            for (int i = 1; i <= 10; i++)
            {   
                for (int j = 2; j <= 5; j++)
                {
                    Console.Write($"{j} x {i} = {i * j}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"\n");
            for (int i = 1; i <= 10; i++)
            {
                for (int k = 6; k <= 9; k++)
                {
                    Console.Write($"{k} x {i} = {i * k}\t");
                }
                Console.WriteLine();
            }
            for (int i = 100; i <= 999; i += 11)
            {
                Console.WriteLine(i);
            }
            //#2
            for (int i = 1; i < 10; i++)
            {
                    
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine($"{i}{j}{i}");
                    Console.WriteLine($"{i}{i}{j}");
                    Console.WriteLine($"{j}{i}{i}");

                }
                for (int k = 0; k < 10; k++)
                {
                    Console.WriteLine($"{i}{k}{i}");
                }
                for (int x = 1; x < 10; x++)
                {
                    Console.WriteLine($"{x}{i}{i}");
                }
            }
            


            Console.ReadLine();
        }
    }
}
