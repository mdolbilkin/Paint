using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace фоновая_6._1
{
    class Figura
    {
        protected int x;
        protected int y;
        public Figura()
        {
            x = 5;
            y = 5;
        }
        public Figura(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Show()
        {
            Console.WriteLine($"{x}, {y}");
        }

    }
    class Triangle : Figura
    {
        private int a;
        private int b;
        private double beta;
        public int A
        {
            get { return a; }
        }
        public int B
        {
            get { return b; }
        }
        public double Beta
        {
            get { return beta; }
        }
        public Triangle(int a, int b, double beta) : base()
        {
            this.a = a;
            this.b = b;
            this.beta = beta;
        }
        public bool isRavnobedr
        {
            get
            {
                if (a == b) return true;
                else if (Math.Abs(a - PoschitatC) < 0.5) return true;
                else if (Math.Abs(b - PoschitatC) < 0.5) return true;
                else return false;
            }
        }
        public double PoschitatC
        {
            get { return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) - 2 * a * b * Math.Cos(beta) * (Math.PI / 180.0)); }
        }
        public void Area()
        {
            double poluper = (a + b + PoschitatC) / 2;
            Console.WriteLine($"Площадь треугольника: {Math.Sqrt(poluper * (poluper - a) * (poluper - b) * (poluper - PoschitatC))}");
        }
        new public void Show()
        {
            base.Show();
            Console.WriteLine($"a = {a}, b = {b}, c = {PoschitatC}, beta = {beta}");
        }
    }
    class Rectangle : Figura
    {
        private int height;
        private int width;

        public int Height
        {
            get { return height; }
        }
        public int Width
        {
            get { return width; }
        }
        public Rectangle(int height, int width) : base()
        {
            this.height = height;
            this.width = width;
        }
        public bool isSquare
        {
            get
            {
                if (height == width) return true;
                else return false;
            }
        }
        new public void Area()
        {
            Console.WriteLine($"Площадь: {width * height}");
        }
        new public void Show()
        {
            base.Show();
            Console.WriteLine($"width = {width}, height = {height}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            Figura[] figura = new Figura[3];
            Rectangle[] rect = new Rectangle[3];
            Triangle[] trian = new Triangle[3];
            for (int i = 0; i < 3; i++)
            {
                figura[i] = new Figura(rd.Next(0, 10), rd.Next(0, 10));
                rect[i] = new Rectangle(rd.Next(0, 10), rd.Next(0, 10));
                trian[i] = new Triangle(rd.Next(0, 10), rd.Next(0, 10), rd.NextDouble());
            }
            Console.ReadLine();
        }
    }
}