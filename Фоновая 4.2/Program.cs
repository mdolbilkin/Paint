using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        struct flights
        {
            public string nplane;
            public int nomer;
            public string dist;
        }
        enum planes
        {
            Ту154 = 0, К7, АН2, АН24, АН124, К9, Ту153
        }
        static void FindAPlane(int number)
        {
            StreamReader f = new StreamReader("C:\\Users\\92552\\Documents\\2021_2022\\0Практики\\Фоновая 4.2\\рейсы.txt");
            for (int i = 0; i < 10; i++)
            {
                string plane = f.ReadLine();
                string a = f.ReadLine();
                int numberflight = int.Parse(a);
                if (numberflight == number)
                {
                    Console.WriteLine($"Тип самолета: {plane} по номеру рейса {number}");
                    break;
                }
                f.ReadLine();
            }
            f.Close();
        }
        static void OutputFlights()
        {
            StreamReader f = new StreamReader("C:\\Users\\92552\\Documents\\2021_2022\\0Практики\\Фоновая 4.2\\рейсы.txt");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} рейс:");
                Console.WriteLine($"\tТип самолета: {f.ReadLine()}");
                Console.WriteLine($"\tНомер рейса: {f.ReadLine()}");
                Console.WriteLine($"\tПункт назначения: {f.ReadLine()}");
                Console.WriteLine();
            }
            f.Close();
        }
        static flights[] FromTxtToMass()
        {
            flights[] myarr = new flights[10];
            StreamReader f = new StreamReader("C:\\Users\\92552\\Documents\\2021_2022\\0Практики\\Фоновая 4.2\\рейсы.txt");
            for (int i = 0; i < 10; i++)
            {
                myarr[i].nplane = f.ReadLine();
                myarr[i].nomer = int.Parse(f.ReadLine());
                myarr[i].dist = f.ReadLine();
            }
            f.Close();
            return myarr;
        }
        static flights[] Input(int n)
        {
            bool fl = true;
            bool pr = false;
            flights[] flyts = new flights[n];
            int mplane;
            string pricl;
            for (int i = 0; i < n; i++)
            {
                while (fl == true)
                {
                    Console.WriteLine("Введите самолет:");
                    Console.WriteLine("Ту154 - 0, К7 - 1, АН2 - 2, АН24 - 3, АН124 - 4, К9 - 5, Ту153 - 6");
                    mplane = int.Parse(Console.ReadLine());
                    
                    for (int j = 0; j < 7; j++)
                    {
                        if ((planes)j == (planes)mplane)
                        {
                            pr = true;
                            break;
                        }
                    }
                    if (pr == true)
                    {
                        pricl = Convert.ToString((planes)mplane);
                        Console.WriteLine("Успешно!");
                        flyts[i].nplane = pricl;
                        fl = false;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка!");
                    }
                }
                fl = true;
                Console.WriteLine("Введите номер рейса(трехзначный): ");
                int numberfl = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите пункт назначения: ");
                string punktnaznach = Console.ReadLine();
                flyts[i].nomer = numberfl;
                flyts[i].dist = punktnaznach;
            }
            return flyts;
        }
        //static void InputFlight(int newflights)
        //{
        //    bool fl = true;
        //    string[] planes = { "Ту154", "К7", "АН2", "АН24", "АН124", "К9", "Ту153" };
        //    StreamWriter f = new StreamWriter("C:\\Users\\92552\\Documents\\2021_2022\\0Практики\\Фоновая 4.2\\новые_рейсы.txt");
        //    string nplane;
        //    for (int i = 0; i < newflights; i++)
        //    {
        //        while (fl == true)
        //        {
        //            Console.WriteLine("Введите самолет:");
        //            nplane = Console.ReadLine();
        //            if (planes.Contains(nplane))
        //            {
        //                Console.WriteLine("Успешно!");
        //                f.WriteLine(nplane);
        //                fl = false;
        //            }
        //            else
        //            {
        //                Console.WriteLine("Ошибка!");
        //            }
        //        }
        //        fl = true;
        //        Console.WriteLine("Введите номер рейса(трехзначный): ");
        //        int numberfl = int.Parse(Console.ReadLine());
        //        Console.WriteLine("Введите пункт назначения: ");
        //        string punktnaznach = Console.ReadLine();
        //        f.WriteLine(numberfl);
        //        f.WriteLine(punktnaznach);
        //    }
        //    f.Close();
        //}
        static void FindDirection(string distanation)
        {
            bool fl = true;
            StreamReader f = new StreamReader("C:\\Users\\92552\\Documents\\2021_2022\\0Практики\\Фоновая 4.2\\рейсы.txt");
            for (int i = 0; i < 10; i++)
            {
                string typeofplane = f.ReadLine();
                string number = f.ReadLine();
                string direction = f.ReadLine();
                if (distanation == direction)
                {
                    Console.WriteLine($"Найден рейс.\nТип самолета: {typeofplane}\nНомер рейса: {number}");
                    fl = false;
                }
            }
            if (fl == true) Console.WriteLine("Таких рейсов нет");
            f.Close();

        }
        static void FindTypeOfPlane(string type, string[] race)
        {
            bool fl = true;
            int a = 0;
            StreamReader f = new StreamReader("C:\\Users\\92552\\Documents\\2021_2022\\0Практики\\Фоновая 4.2\\рейсы.txt");
            for (int i = 0; i < 10; i++)
            {
                string typeofplane = f.ReadLine();
                string number = f.ReadLine();
                string direction = f.ReadLine();
                if (type == typeofplane)
                {
                    Console.WriteLine($"{race[a]}\nНомер рейса: {number}\nПункт назначения: {direction}");
                    fl = false;
                    a++;
                }
            }
            if (fl == true) Console.WriteLine("Таких рейсов нет");
            f.Close();
        }
        static void Main(string[] args)
        {
            flights[] newarr = new flights[10];
            newarr = FromTxtToMass();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{newarr[i].nplane}, {newarr[i].nomer}, {newarr[i].dist}");
            }
            Console.WriteLine();
            string[] race = { "Найден рейс.", "Найден еще один рейс.", "И еще один.", "И снова найден." };
            Console.WriteLine("Вы хотите добавить в базу рейсы?");
            if (Console.ReadLine() == "Да")
            {
                Console.WriteLine("Сколько рейсов хотите добавить?");
                int n = int.Parse(Console.ReadLine());
                flights[] rez = new flights[n];
                rez = Input(n);
            }
            Console.WriteLine("Хотите посмотреть основную базу рейсов?");
            if (Console.ReadLine() == "Да")
            {
                OutputFlights();
            }
            Console.WriteLine("Если вы хотите осуществить поиск типа самолета, введите номер рейса: ");
            string number = Console.ReadLine();
            if (number != "Нет")
            {
                FindAPlane(int.Parse(number));
            }
            string direction;
            Console.WriteLine("Поиск по пункту назначения: ");
            direction = Console.ReadLine();
            if (direction != "Нет")
            {
                FindDirection(direction);
            }
            Console.WriteLine("Поиск по типу самолету:");
            string type = Console.ReadLine();
            if (type != "Нет")
            {
                FindTypeOfPlane(type, race);
            }
            Console.ReadLine();
        }
    }
}
