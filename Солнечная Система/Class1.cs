using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Солнечная_Система
{
    abstract class Astro
    {
        protected int x;
        protected int y;
        protected int Radius;
        public int GRadius
        {
            get { return Radius; }
        }
        public Astro(int x, int y, int radius)
        {
            this.x = x;
            this.y = y;
            Radius = radius;
        }
        public abstract void Draw(Graphics graphics, Brush brush);
    }
    class Sun : Astro
    {
        Color color = Color.Yellow;
        public Color Color
        {
            get { return color; }
        }
        public Sun(int x, int y, int radius) : base(x, y, radius)
        {

        }
        public override void Draw(Graphics graphics, Brush brush)
        {
            graphics.FillEllipse(brush, x - GRadius, y - GRadius, 2 * GRadius, 2 * GRadius);
        }
    }
    class Saturn : Astro
    {
        Color color = Color.SandyBrown;
        public Color Color
        {
            get { return color; }
        }
        public Saturn(int x, int y, int radius) : base(x, y, radius)
        {

        }
        public override void Draw(Graphics graphics, Brush brush)
        {
            Pen pen = new Pen(Color.Brown);
            pen.Width = 10;
            graphics.FillEllipse(brush, x - GRadius, y - GRadius, 2 * GRadius, 2 * GRadius);
            graphics.DrawArc(pen, x - GRadius - 5, y - GRadius + 20, 2 * GRadius + 10, GRadius, 10, 185);
        }
    }
    class Kometa : Astro
    {
        Color color = Color.White;
        public Color Color
        {
            get { return color; }
        }
        public Kometa(int x, int y, int radius) : base(x, y, radius)
        {

        }
        public override void Draw(Graphics graphics, Brush brush)
        {
            Pen pen = new Pen(color);
            pen.Width = 3;
            graphics.FillEllipse(brush, x - GRadius, y - GRadius, 2 * GRadius, 2 * GRadius);
            graphics.DrawLine(pen, x, y, x - 45, y);
            graphics.DrawLine(pen, x, y, x - 45, y - 20);
            graphics.DrawLine(pen, x, y , x - 45, y + 20);
        }
    }
    class Moon : Astro
    {
        Color color = Color.DarkGray;
        public Color Color
        {
            get { return color; }
        }
        public Moon(int x,int y, int radius) : base(x, y, radius)
        {

        }
        public override void Draw(Graphics graphics, Brush brush)
        {
            Brush brush1 = new SolidBrush(Color.LightGray);
            graphics.FillEllipse(brush, x - GRadius, y - GRadius, 2 * GRadius, 2 * GRadius);
            graphics.FillEllipse(brush1, x - GRadius + 7, y - GRadius + 7,  GRadius - 20, GRadius - 20);
            graphics.FillEllipse(brush1, x - GRadius + 30, y - GRadius + 30, GRadius - 10, GRadius - 10);
            graphics.FillEllipse(brush1, x - GRadius + 25, y - GRadius + 7, GRadius - 15, GRadius - 15);
        }
    }
    class Mars : Astro
    {
        Color color = Color.IndianRed;
        public Color Color
        {
            get { return color; }
        }
        public Mars(int x, int y, int radius) : base(x, y, radius)
        {

        }
        public override void Draw(Graphics graphics, Brush brush)
        {
            graphics.FillEllipse(brush, x - GRadius, y - GRadius, 2 * GRadius, 2 * GRadius);
        }
    }
    class Crescent : Astro
    {
        Color color = Color.WhiteSmoke;
        public Color Color
        {
            get { return color; }
        }
        public Crescent(int x, int y, int radius) : base(x, y, radius)
        {

        }
        public override void Draw(Graphics graphics, Brush brush)
        {
            Pen pen = new Pen(color);
            pen.Width = 3;
            graphics.DrawArc(pen, x - GRadius - 5, y - GRadius + 20, 2 * GRadius, 2 * GRadius, 80, 200);
            pen.Width = 5;
            graphics.DrawArc(pen, x - GRadius - 2, y - GRadius + 24, 2 * GRadius - 7 , 2 * GRadius - 7, 90, 180);
        }
    }
}
