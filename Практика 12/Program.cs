using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_12
{
    class point3D
    {
        public int x;
        public int y;
        public int z;
        public point3D()
        {
            x = 0;
            y = 0;
            z = 0;
        }
        public point3D(int a, int b, int c)
        {
            x = a;
            y = b;
            z = c;
        }
        public void Change(string ox, int abc)
        {
            if (ox == "x") x += abc;
            if (ox == "y") y += abc;
            if (ox == "z") z += abc;
        }
        public void Vivod()
        {
            Console.WriteLine($"Точка имеет координаты ({x};{y};{z})");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            point3D obj1, obj2;
            Console.WriteLine("Какую точку хочешь взять, со своими координатами или с  нулевыми?");
            if (int.Parse(Console.ReadLine()) == 1)
            {
                obj1 = new point3D(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            }
            else
            {
                obj1 = new point3D();
            }
            Console.WriteLine("Хочешь сдвинуть точки?(введи координату)");
            obj1.Change(Console.ReadLine(), int.Parse(Console.ReadLine()));
            Console.WriteLine($"Точка имеет координаты ({obj1.x};{obj1.y};{obj1.z})");
            Console.ReadLine();
        }
    }
}
