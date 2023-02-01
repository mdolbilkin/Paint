using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace paint
{
    class RadiusEventArgs 
    {
        public int radius { get; set; }
        public RadiusEventArgs(int radius)
        {
            this.radius = radius;
        }
        public delegate void RadiusEventHandler(object sender, RadiusEventArgs e);
        public event RadiusEventHandler RadiusChanged
        {
            add
            {
                Console.WriteLine("add");
            }
            remove { Console.WriteLine("remove"); }
    }
    abstract class Shape
    {
        protected int x;
        protected int y;
        protected bool draft;
        public bool drawline { get; set; }
        public int dx { get; set; }
        public int dy { get; set; }
        static int Radius;
        static Color color;
        static Shape()
        {
            Radius = 25;
            color = Color.Blue;
        }
        public Shape(int x, int y)
        {
            draft = false;
            this.x = x;
            this.y = y;
        }
        public abstract bool isInside(int mx, int my);
        public abstract void Draw(Graphics graphics, Brush brush);
        public int GRadius
        {
            get
            {
                return Radius;
            }
            set
            {
                Radius = value;
            }
        }
        public int xx
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public int yy
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public bool d
        {
            get
            {
                return draft;
            }
            set
            {
                try
                {
                    draft = value;
                }
                catch
                {
                    Console.WriteLine();
                }
            }
        }
    }
    class Ellipse : Shape
    {
        public Ellipse(int x, int y) : base(x, y)
        {

        }
        public override void Draw(Graphics G, Brush b)
        {
            G.FillEllipse(b, xx - GRadius, yy - GRadius, 2 * GRadius, 2 * GRadius);
        }
        public override bool isInside(int mx, int my)
        {
            return Math.Abs(mx - x) <= GRadius && Math.Abs(my - y) <= GRadius;
        }
    }
    class Square : Shape
    {
        public Square(int x, int y) : base(x, y)
        {

        }
        public override void Draw(Graphics graphics, Brush brush)
        {
            graphics.FillRectangle(brush, x - GRadius, y - GRadius, 2 * GRadius, 2 * GRadius);
            //graphics.FillRectangle(brush, x - (GRadius / (float)(Math.Sin(45)) / 2), y - (GRadius / (float)(Math.Sin(45)) / 2), 2 * GRadius, 2 * GRadius));
        }
        public override bool isInside(int mx, int my)
        {
            return x + (GRadius / (float)(Math.Sin(45)) / 2) >= mx && mx >= x - (GRadius / (float)(Math.Sin(45)) / 2) && my <= y + (GRadius / (float)(Math.Sin(45)) / 2) && my >= y - (GRadius / (float)(Math.Sin(45)) / 2);
        }
    }
    class Triangle : Shape
    {
        public Triangle(int x, int y) : base(x ,y)
        {

        }
        public override void Draw(Graphics graphics, Brush brush)
        {
            Point point1 = new Point(x, y - GRadius);
            Point point2 = new Point(x - GRadius, y + GRadius);
            Point point3 = new Point(x + GRadius, y + GRadius);
            Point[] points = {point3, point1, point2 };
            graphics.FillPolygon(brush, points);
        }
        public override bool isInside(int mouse_x, int mouse_y)
        {
            double x1, y1, x2, y2, x3, y3;
            x1 = x - (GRadius / 2 * Math.Sqrt(3));
            y1 = (y + GRadius / 2.0);
            x2 = x;
            y2 = y - GRadius;
            x3 = x + (GRadius / 2 * Math.Sqrt(3));
            y3 = y1;
            if (mouse_y < y + GRadius / 2.0 && mouse_y > (double)(y2 - y1) / (x2 - x1) * mouse_x + (y1 - (double)(y2 - y1) / (x2 - x1) * x1))
            {
                if (mouse_y > (double)(y3 - y2) / (x3 - x2) * mouse_x + (y2 - (double)(y3 - y2) / (x3 - x2) * x2))
                {
                    return true;
                }
            }
            return false;
        }


    }
}
