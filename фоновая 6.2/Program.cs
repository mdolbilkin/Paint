using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace фоновая_6._2
{
    class Parallelogram
    {
        protected double alfa;
        protected int width;
        protected int h;
        public int H
        {
            get { return h; }
            set
            {
                try
                {
                    if (value <= 0)
                    {
                        throw new Exception("Отрицательный ввод");
                    }
                    else
                    {
                        h = value;
                    }
                }
                catch (Exception k)
                {
                    Console.WriteLine(k.Message);
                }
            }
        }
        public int Width
        {
            get { return width; }
            set
            {
                try
                {
                    if (value <= 0)
                    {
                        throw new Exception("Отрицательный ввод");
                    }
                    else
                    {
                        width = value;
                    }
                }
                catch (Exception k)
                {
                    Console.WriteLine(k.Message);
                }
            }
        }
        public double Alfa
        {
            get { return alfa; }
            set
            {
                try
                {
                    if (value <= 0 || value > 179)
                    {
                        throw new Exception("Отрицательный ввод");
                    }
                    else
                    {
                        alfa = value;
                    }
                }
                catch (Exception k)
                {
                    Console.WriteLine(k.Message);
                }
            }
        }
        public virtual bool isSquare
        {
            get
            {
                if (alfa == 90.0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public double Storona
        {
            get
            {
                return h / Math.Sin(alfa);
            }
        }
        public virtual int Area()
        {
            return h * width;
        }
        public virtual void Show()
        {
            Console.WriteLine($"width = {width}, h = {h}, alfa = {alfa}");
        }
        public virtual double Perimetr()
        {
            return 2 * Storona * width;
        }
        public virtual double Diagonal()
        {
            return Math.Sqrt((Storona * Storona + width * width) - (2 * Storona * width * Math.Cos(alfa)));
        }
        public Parallelogram()
        {
            alfa = 60.0;
            width = 10;
            h = 4;
        }
        public Parallelogram(double alfa, int width, int h)
        {
            this.h = h;
            this.alfa = alfa;
            this.width = width;
        }

    }
    class Rectangle : Parallelogram
    {
        public Rectangle(double alfa, int width, int h) :base(alfa, width, h)
        {

        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Это прямоугольник");
        }
        public override double Diagonal()
        {
            return Math.Sqrt(h*h + width*width);
        }
        public override bool isSquare => base.isSquare;

    }
    class Romb : Parallelogram
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
