using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фоновая_3._2
{
    class Program
    {
        static int[] newarr(int n)
        {
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }
        static void output(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0} ", a[i]);
            }
        }
        static int RavnayRaznost(int[] a, int k)
        {
            int count = 0;
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (Math.Abs(a[i] - a[i + 1]) == k) count++;
            }
            return count;
        }
        static int[] zamena(int[] a)
        {
            int proiz = 1;
            int max = -999999;
            int min = 9999999;
            int sum = 0;
            int k = 0;
            int count = 0;
            
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0)
                {
                    sum += Math.Abs(a[i]);
                    if (a[i] > max)
                    {

                        max = a[i];
                        k = i;
                        count++;
                    }
                }
            }
            if (count != 0)
            {
                a[k] = sum;
                k = 0;
                count = 0;
            }
            
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0)
                {
                    proiz *= a[i];
                    if (a[i] < min)
                    {
                        min = a[i];
                        k = i;
                        count++;
                    }
                    
                }
            }
            if(count != 0)
            {
                a[k] = proiz;
                
            }
            return a;

        }
        static void Main(string[] args)
        {
            Console.Write("Напишите длину массива:");
            int a = int.Parse(Console.ReadLine());
            int[] arr1 = new int[a];
            arr1 = newarr(a);
            output(arr1);
            int rez = 0;
            Console.WriteLine();
            Console.WriteLine("Напишите число K:");
            int l = int.Parse(Console.ReadLine());
            rez = RavnayRaznost(arr1, l);
            Console.WriteLine(rez);
            int[] otvet = new int[a];
            otvet = zamena(arr1);
            output(otvet);
            Console.ReadLine();
        }
    }
}
