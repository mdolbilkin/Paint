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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace paint
{
    
    public partial class Form1 : Form
    { 
        Shape c;
        BinaryFormatter formatter;
        //Ellipse c = new Ellipse(100, 100);
        //Shape[] objects = new Shape[5];
        List<Shape> objects = new List<Shape>();
        List<Point> points = new List<Point>();
        bool moveobolochka;
        Color color = Color.Red;
        Form2 fm2;
        //Square c = new Square(100, 100);
        //Triangle c = new Triangle(100, 100);
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            formatter = new BinaryFormatter();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "binary files(*.bin)|*.bin";
            openFileDialog1.Filter = "binary files(*.bin)|*.bin";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        public static double cosinus(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            double Xba = x1 - x2;    //угол - abc, firstpoint - точка относительно которой смотрим сейчас
            double Yba = y1 - y2;
            double Xbc = x3 - x2;
            double Ybc = y3 - y2;
            double Lenba = Math.Sqrt(Xba * Xba + Yba * Yba);
            double Lenbc = Math.Sqrt(Xbc * Xbc + Ybc * Ybc);
            return (double)(Xba * Xbc + Yba * Ybc) / (Lenba * Lenbc);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int levo = 0;
            int pravo = 0;
            try
            {
                Brush br = new SolidBrush(color);
                Pen pen = new Pen(color);
                foreach (Shape objec1 in objects)
                {
                    objec1.Draw(e.Graphics, br);
                }
                for (int i = 0; i < objects.Count; i++)
                    objects[i].drawline = false;
                if (opredToolStripMenuItem.Checked)
                {
                    
                    if (objects.Count >= 3)
                    {
                        int cntL, cntR;
                        
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
                }
                else if (jarvisToolStripMenuItem.Checked)
                {
                    if (objects.Count >= 3)
                    {
                        Shape ppoint;
                        Shape fpoint = objects[0];
                        Shape spoint = objects[0];
                        int maxy = 0;
                        for (int i = 0; i < objects.Count; i++)
                        {
                            if (objects[i].yy > maxy)
                            {
                                maxy = objects[i].yy;
                                fpoint = objects[i];
                            }
                            if (objects[i].yy == maxy && objects[i].xx < fpoint.xx)
                            {
                                fpoint = objects[i];
                            }
                        }
                        ppoint = new Ellipse(fpoint.xx - 100, fpoint.yy);
                        double mincos = 1;
                        for (int i = 0; i < objects.Count; i++)
                        {
                            if (objects[i].xx != fpoint.xx && objects[i].yy != fpoint.yy)
                            {
                                if (cosinus(ppoint.xx, ppoint.yy, fpoint.xx, fpoint.yy, objects[i].xx, objects[i].yy) < mincos)
                                {
                                    mincos = cosinus(ppoint.xx, ppoint.yy, fpoint.xx, fpoint.yy, objects[i].xx, objects[i].yy);
                                    spoint = objects[i];
                                }
                            }
                        }
                        e.Graphics.DrawLine(new Pen(Color.Black), fpoint.xx, fpoint.yy, spoint.xx, spoint.yy);

                        Shape startp = fpoint;
                        while (spoint.xx != startp.xx && spoint.yy != startp.yy)
                        {
                            fpoint.drawline = true;
                            spoint.drawline = true;
                            ppoint = fpoint;
                            fpoint = spoint;

                            mincos = 1;
                            for (int i = 0; i < objects.Count; i++)
                            {
                                if (objects[i].xx != fpoint.xx && objects[i].yy != fpoint.yy)
                                {
                                    if (cosinus(ppoint.xx, ppoint.yy, fpoint.xx, fpoint.yy, objects[i].xx, objects[i].yy) < mincos)
                                    {
                                        mincos = cosinus(ppoint.xx, ppoint.yy, fpoint.xx, fpoint.yy, objects[i].xx, objects[i].yy);
                                        spoint = objects[i];
                                    }
                                }
                            }
                            e.Graphics.DrawLine(new Pen(Color.Black), fpoint.xx, fpoint.yy, spoint.xx, spoint.yy);
                        }
                    }

                   
                }
                
                Console.WriteLine(objects[objects.Count - 1].drawline);
                if (objects[objects.Count - 1].drawline == false && objects.Count > 2)
                {
                    foreach (Shape objec in objects)
                    {
                        objec.d = true;
                        objec.dx = objec.xx - objects[objects.Count - 1].xx;
                        objec.dy = objec.yy - objects[objects.Count - 1].yy;
                        Console.WriteLine($"ssd:  {objec.d}");
                    }
                }
                Console.WriteLine($"asd: {moveobolochka}");



            }
            catch { Console.WriteLine("Ошибка в paint"); }
            //Graphics G = CreateGraphics();
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //Console.WriteLine(moveobolochka);
            bool fl = false;
            int levo = 0;
            int pravo = 0;
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    for (int i = 0; i < objects.Count; i++)
                    {
                        if (objects[i].isInside(e.X, e.Y))
                        {
                            objects.RemoveAt(i);
                            Refresh();
                            break;
                        }
                    }
                }
                else
                {
                    foreach (Shape objec in objects)
                    {
                        if (objec.isInside(e.X, e.Y))
                        {
                            fl = true;
                            objec.d = true;
                            objec.dx = objec.xx - e.X;
                            objec.dy = objec.yy - e.Y;
                            
                        }
                    }
                    if (fl == false)
                    {
                        //Console.WriteLine(moveobolochka);
                        
                        if (triangleToolStripMenuItem.Checked)
                        {
                            Triangle c = new Triangle(100, 100);
                            c.xx = e.X;
                            c.yy = e.Y;
                            c.d = true;
                            objects.Add(c);
                        }
                        if (squareToolStripMenuItem.Checked)
                        {
                            Square c = new Square(100, 100);
                            c.xx = e.X;
                            c.yy = e.Y;
                            c.d = true;
                            objects.Add(c);
                        }
                        if (circleToolStripMenuItem.Checked)
                        {
                            Ellipse c = new Ellipse(100, 100);
                            c.xx = e.X;
                            c.yy = e.Y;
                            c.d = true;
                            objects.Add(c);

                        }
                        Refresh();
                        
                        if (objects.Count >= 3)
                        {
                            for (int i = objects.Count - 1; i >=0; i--)
                            {
                                if (objects[i].d = false)
                                {
                                    objects.RemoveAt(i);
                                    i -= 1;
                                }
                            }
                            Console.WriteLine(1);
                            Refresh();
                        }

                        
                    }


                    //Console.WriteLine(objects);
                    
                }
                
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
            if (objects.Count != 0)
            {
                foreach (Shape objec in objects)
                {
                    if (objec.d)
                    {
                        objec.xx = e.X + objec.dx;
                        objec.yy = e.Y + objec.dy;
                        Console.WriteLine("MOve");

                    }
                }

                Refresh();
            }
            

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            moveobolochka = false;
            foreach (Shape objec in objects)
            {
                objec.d = false;
            }
            if (objects.Count >= 3)
            {
                for (int i = 0; i < objects.Count; i++)
                {
                    if (objects[i].drawline == false)
                    {
                        objects.RemoveAt(i);
                        i -= 1;
                    }
                }
            }
        }

        private void algorythmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void opredToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(opredToolStripMenuItem.Checked == false)
            {
                opredToolStripMenuItem.Checked = true;
                jarvisToolStripMenuItem.Checked = false;
            }
            
            
        }

        private void jarvisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(jarvisToolStripMenuItem.Checked == false)
            {
                jarvisToolStripMenuItem.Checked = true;
                opredToolStripMenuItem.Checked = false;
            }
        }

        private void button_Color_Click(object sender, EventArgs e)
        {
            
        }

        //private void testToolStripMenuItem_Click(object sender, RadiusEventArgs e)
        //{
            
        //    Form2 fm2 = new Form2();
        //    fm2.RadiusChanged += new RadiusEventHandler(UpdateRadius);
        //    fm2.ShowDialog();

        //}
        private void UpdateRadius(object sender, RadiusEventArgs e)
        {
            foreach (Shape objec1 in objects)
            {
                objec1.GRadius = e.radius;
                
            }
            Refresh();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            color = colorDialog1.Color;

        }

        private void radiusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fm2 == null)
            {
                fm2 = new Form2(objects[0].GRadius);
                fm2.RadiusChanged += new RadiusEventHandler(UpdateRadius);
                fm2.Show();
            }
            else
            {
                fm2.Activate();
                if (fm2.IsDisposed)
                {
                    fm2 = new Form2(objects[0].GRadius);
                    fm2.RadiusChanged += new RadiusEventHandler(UpdateRadius);
                    fm2.Show();
                }
                if (fm2.WindowState == System.Windows.Forms.FormWindowState.Minimized)
                {
                    fm2.WindowState = System.Windows.Forms.FormWindowState.Normal;
                }
            }
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            using (Stream stream = new FileStream(openFileDialog1.FileName, FileMode.Open))
            {
                objects = (List<Shape>)formatter.Deserialize(stream);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create))
            {
                formatter.Serialize(stream, objects);
            }
        }
    }
    public class RadiusEventArgs : EventArgs
    {
        public int radius { get; set; }
        public RadiusEventArgs(int radius)
        {
            this.radius = radius;
        }


    }
    public delegate void RadiusEventHandler(object sender, RadiusEventArgs e);
}
