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
        //Square c = new Square(100, 100);
        //Triangle c = new Triangle(100, 100);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                Brush b = new SolidBrush(Color.Blue);
                foreach (Shape objec1 in objects)
                {
                    objec1.Draw(e.Graphics, b);
                }
            }
            catch { Console.WriteLine("Ошибка в paint"); }
            //Graphics G = CreateGraphics();
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            bool fl = false;
            try
            {
                foreach (Shape objec in objects)
                {
                    if (objec.isInside(e.X, e.Y))
                    {
                        fl = true;
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
    }
}
