using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Практика
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            double r = 64.100;
            double p1 = 0.78932597F;
            double pr = 100000000000f;
            double f1 = 3.20000;
            decimal dec = 18500.5m;
            int s1, p;
            s1 = 4;
            p = 16;
            string s = "AMD";
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите дробное число: ");
            double f = Double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"Привет, {name}!");
            Console.WriteLine($"*********************************\n*\tЯ твой компьютер!\t*\n*********************************");
            Console.WriteLine("У меня следующие характеристики:");
            Console.WriteLine();
            Console.WriteLine($"Процессор\t{s} с разрядностью {f1:f2}GHz\nМоя память\t{p}Gb (доступно {p1:p0    })\nЖесткий диск\t{s1*1024:e2} Gb\nТип системы\t{r:f0}-разрядная OC");
            Console.WriteLine();
            Console.WriteLine($"Моя производительность\t{pr:E0} оп/сек\nИндекс прозв-ти\t\t\t{f:F0}\nМоя стоимость\t\t{dec:c2}");
            Console.ReadLine();

        }
    }   
}
