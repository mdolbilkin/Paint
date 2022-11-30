using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //#1
            Console.WriteLine("Введите дальность выстрела:");
            int a = int.Parse(Console.ReadLine());
            if (a <= 0) Console.WriteLine("Не бей по своим!");
            else if (a <= 28) Console.WriteLine("Недолет");
            else if (a >= 32) Console.WriteLine("Перелет");
            else Console.WriteLine("Попал");
            //#2
            Console.WriteLine("Введите число:"); int number = int.Parse(Console.ReadLine());
            string l = ((number / 10) == 0) ? "Да" : "Нет";
            Console.WriteLine(l);
            //#3
            int k = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double dis = Math.Pow(b, 2) - (4 * k * c);
            int f = 0;
            if (dis > 0.0) f = 3;
            if (dis < 0.0) f = 1;
            if (dis == 0.0) f = 2;
            switch (f)
            {
                case  3:
                    Console.WriteLine("2 Корня");
                    break;
                case 1:
                    Console.WriteLine("0 Корней");
                    break;
                default:
                    Console.WriteLine("1 Корень");
                    break;
            }
            Console.ReadLine();
            //Увы, нет возможности поговорить, терпимо - я зачту
        }
    }
}
