using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_9
{
    class Program
    {
        static int Length(string a)
        {
            int c = a.Length;
            return c;
        }
        static void StrokaWithOutSkobki(ref string a)
        {
            int b = 0;
            string res = a;
            int k = 0;
            for (int i = 0; i < res.Length; i++)
            {
                if (String.Equals(a.Substring(k, 1), "("))
                {
                    b = 1;
                }
                if (String.Equals(a.Substring(k, 1), ")"))
                {
                    b = 0;
                    a = a.Remove(k, 1);
                    k--;
                }
                if (b == 1)
                {
                    a = a.Remove(k,1);
                    k--;
                }
                
                k++;
            }
        }
        static void Main(string[] args)
        {
            string stroka = Console.ReadLine();
            int res = Length(stroka);
            Console.WriteLine(res);
            StrokaWithOutSkobki(ref stroka);
            Console.WriteLine(stroka);
            Console.ReadLine();
        }
    }
}
