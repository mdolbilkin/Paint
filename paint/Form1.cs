using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint
{
    public partial class Form1 : Form
    {
        Shape c;
        //Ellipse c = new Ellipse(100, 100);
        //Shape[] objects = new Shape[5];
        List<Shape> objects = new List<Shape>();
        List<Point> points = new List<Point>();
        //Square c = new Square(100, 100);
        //Triangle c = new Triangle(100, 100);
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int levo = 0;
            int pravo = 0;
            try
            {
                Brush br = new SolidBrush(Color.Blue);
                Pen pen = new Pen(Color.Black);
                foreach (Shape objec1 in objects)
                {
                    objec1.Draw(e.Graphics, br);
                }
                if (objects.Count >= 3)
                {
                    int cntL, cntR;
                    for (int i = 0; i < objects.Count; i++)
                        objects[i].drawline = false;
                    for (int i = 0; i < objects.Count; i++)
                    {
                        for (int j = i + 1; j < objects.Count; j++)
                        {
                            cntL = cntR = 0;
                            float k = ((float)objects[j].yy - objects[i].yy) / ((float)objects[j].xx - objects[i].xx);
                            float b = objects[i].yy - k * objects[i].xx;
                            for (int l = 0; l < objects.Count; l++)
                            {
                                if (l != i && l != j)
                                {
                                    if (objects[l].yy > k * objects[l].xx + b)
                                        cntR++;
                                    else
                                        cntL++;
                                }
                            }
                            if (cntR * cntL == 0 && objects[i].xx != objects[j].xx)
                            {
                                e.Graphics.DrawLine(pen, objects[i].xx, objects[i].yy, objects[j].xx, objects[j].yy);
                                objects[i].drawline = true;
                                objects[j].drawline = true;
                            }
                        }
                    }
                }
                //    if (objects.Count > 2)
                //{
                //    for (int i = 0; i < objects.Count; i++)
                //    {
                //        objects[i].drawline = false;
                //        for (int j = 0; j < objects.Count; j++)
                //        {
                //            float k = ((float)objects[j].yy - objects[i].yy) / ((float)objects[j].xx - objects[i].xx);
                //            float b = objects[i].yy - k * objects[i].xx;
                //            if (k != 0)
                //            {
                //                for (int n = 0; n < objects.Count; n++)
                //                {
                //                    if (n != j && n != i)
                //                    {
                //                        if (objects[n].yy < objects[n].xx * k + b)
                //                        {
                //                            pravo += 1;
                //                        }
                //                        else
                //                        {
                //                            levo += 1;
                //                        }
                //                    }
                //                }
                //                if (pravo * levo == 0 && objects[i].xx != objects[j].xx)
                //                {
                //                    e.Graphics.DrawLine(pen, objects[i].xx, objects[i].yy, objects[j].xx, objects[j].yy);
                //                    objects[i].drawline = true;
                //                    objects[j].drawline = true;
                //                }
                //            }

                //        }
                //    }
                //}
            }
            catch { Console.WriteLine("Ошибка в paint"); }
            //Graphics G = CreateGraphics();
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            bool fl = false;
            int levo = 0;
            int pravo = 0;
            try
            {
                foreach (Shape objec in objects)
                {
                    if (objec.isInside(e.X, e.Y))
                    {
                        fl = true;
                        objec.d = true;
                        objec.dx = objec.xx - e.X;
                        objec.dy = objec.yy - e.Y;
                        break;
                    }
                }
                if (fl == false)
                {
                    if (triangleToolStripMenuItem.Checked)
                    {
                        Triangle c = new Triangle(100, 100);
                        c.xx = e.X;
                        c.yy = e.Y;
                        objects.Add(c);
                    }
                    if (squareToolStripMenuItem.Checked)
                    {
                        Square c = new Square(100, 100);
                        c.xx = e.X;
                        c.yy = e.Y;
                        objects.Add(c);
                    }
                    if (circleToolStripMenuItem.Checked)
                    {
                        Ellipse c = new Ellipse(100, 100);
                        c.xx = e.X;
                        c.yy = e.Y;
                        objects.Add(c);
                    }
                }
                
                
                Console.WriteLine(objects);
                Refresh();
            }
            catch { Console.WriteLine("Menustrip не выбран"); }
            
        }

        private void triangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (triangleToolStripMenuItem.Checked == false)
            {
                triangleToolStripMenuItem.Checked = true;
                circleToolStripMenuItem.Checked = false;
                squareToolStripMenuItem.Checked = false;
            }
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (circleToolStripMenuItem.Checked == false)
            {
                triangleToolStripMenuItem.Checked = false;
                circleToolStripMenuItem.Checked = true;
                squareToolStripMenuItem.Checked = false;
            }
        }

        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (squareToolStripMenuItem.Checked == false)
            {
                triangleToolStripMenuItem.Checked = false;
                circleToolStripMenuItem.Checked = false;
                squareToolStripMenuItem.Checked = true;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (Shape objec in objects)
            {
                if (objec.d)
                {
                    objec.xx = e.X + objec.dx;
                    objec.yy = e.Y + objec.dy;
                    Refresh();
                }
            }
            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            foreach (Shape objec in objects)
            {
                objec.d = false;
            }
        }
    }
}
