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
    abstract class Shape
    {
        protected int x;
        protected int y;
        static int Radius;
        static Color color;
        static Shape()
        {
            Radius = 50;
            color = Color.Blue;
        }
        public Shape(int x, int y)
        {
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
            graphics.FillRectangle(brush, x - (GRadius / (float)(Math.Sin(45)) / 2), y - (GRadius / (float)(Math.Sin(45)) / 2), GRadius / (float)(Math.Sin(45)), GRadius / (float)(Math.Sin(45)));
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
            Point p1 = new Point(xx, yy - GRadius);
            Point p2 = new Point(xx + (int)(GRadius * Math.Sqrt(3) / 2), yy + GRadius / 2);
            Point p3 = new Point(xx - (int)(GRadius * Math.Sqrt(3) / 2), yy + GRadius / 2);
            Point[] points = { p1, p2, p3 };
            int a = (points[0].X - mouse_x) * (points[1].Y - points[0].Y) - (points[1].X - points[0].X) * (points[0].Y - mouse_y);
            int b = (points[1].X - mouse_x) * (points[2].Y - points[1].Y) - (points[2].X - points[1].X) * (points[1].Y - mouse_y);
            int c = (points[2].X - mouse_x) * (points[0].Y - points[2].Y) - (points[0].X - points[2].X) * (points[2].Y - mouse_y);
            return (a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0);
        }


    }
}
