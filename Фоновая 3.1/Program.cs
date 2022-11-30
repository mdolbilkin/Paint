using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фоновая_3._1
{
    class Program
    {
        static void NumbersOfTransport(string stroka)
        {
            if (stroka.Length == 5)
            {
                if(Char.IsLetter(stroka[0]) && Char.IsLetter(stroka[1]))
                {
                    if (Char.IsDigit(stroka[2]) && Char.IsDigit(stroka[3]) && Char.IsDigit(stroka[4])) Console.WriteLine(2);
                    else Console.WriteLine(0);
                }
                else Console.WriteLine(0);
            }
            else if (stroka.Length == 6)
            {
                if (Char.IsLetter(stroka[0]) && Char.IsLetter(stroka[1]))
                {
                    if (Char.IsDigit(stroka[2]) && Char.IsDigit(stroka[3]) && Char.IsDigit(stroka[4]) && Char.IsDigit(stroka[5])) Console.WriteLine(3);
                    else Console.WriteLine(0);
                }
                else if (Char.IsLetter(stroka[0]))
                {
                    if (Char.IsDigit(stroka[1]) && Char.IsDigit(stroka[2]) && Char.IsDigit(stroka[3]) && Char.IsLetter(stroka[4]) && Char.IsLetter(stroka[5]))
                    {
                        Console.WriteLine(1);
                    }
                    else Console.WriteLine(0);
                }
                else if (Char.IsDigit(stroka[0]) && Char.IsDigit(stroka[1]) && Char.IsDigit(stroka[2]) && Char.IsDigit(stroka[3]))
                {
                    if (Char.IsLetter(stroka[4]) && Char.IsLetter(stroka[5])) Console.WriteLine(4);
                    else Console.WriteLine(0);
                }
                else Console.WriteLine(0);
            }
            else Console.WriteLine(0);
        }
        static void Main(string[] args)
        {
            string stroka = Console.ReadLine();
            NumbersOfTransport(stroka);
            Console.ReadLine();
        }
    }
}
