using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Солнечная_Система
{
    public partial class Form1 : Form
    {
        Sun sun = new Sun(250, 150, 50);
        Saturn saturn = new Saturn(400, 200, 45);
        Kometa kometa = new Kometa(100, 100, 15);
        Moon moon = new Moon(500, 200, 30);
        Mars mars = new Mars(600, 300, 45);
        Crescent crescent = new Crescent(600, 150, 30);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sunToolStripMenuItem.Checked)
            {
                sunToolStripMenuItem.Checked = false;
                Refresh();
            }
            else
            {
                sunToolStripMenuItem.Checked = true;
                Refresh();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (sunToolStripMenuItem.Checked)
            {
                Brush b = new SolidBrush(sun.Color);
                sun.Draw(e.Graphics, b);
            }
            if (saturnToolStripMenuItem.Checked)
            {
                Brush b = new SolidBrush(saturn.Color);
                saturn.Draw(e.Graphics, b);
            }
            if (kometaToolStripMenuItem.Checked)
            {
                Brush b = new SolidBrush(kometa.Color);
                kometa.Draw(e.Graphics, b);
            }
            if (moonToolStripMenuItem.Checked)
            {
                Brush b = new SolidBrush(moon.Color);
                moon.Draw(e.Graphics, b);
            }
            if (marsToolStripMenuItem.Checked)
            {
                Brush b = new SolidBrush(mars.Color);
                mars.Draw(e.Graphics, b);
            }
            if (crescentToolStripMenuItem.Checked)
            {
                Brush b = new SolidBrush(crescent.Color);
                crescent.Draw(e.Graphics, b);
            }
        }

        private void saturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saturnToolStripMenuItem.Checked)
            {
                saturnToolStripMenuItem.Checked = false;
                Refresh();
            }
            else
            {
                saturnToolStripMenuItem.Checked = true;
                Refresh();
            }
        }

        private void kometaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kometaToolStripMenuItem.Checked)
            {
                kometaToolStripMenuItem.Checked = false;
                Refresh();
            }
            else
            {
                kometaToolStripMenuItem.Checked = true;
                Refresh();
            }
        }

        private void moonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (moonToolStripMenuItem.Checked)
            {
                moonToolStripMenuItem.Checked = false;
                Refresh();
            }
            else
            {
                moonToolStripMenuItem.Checked = true;
                Refresh();
            }
        }

        private void marsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (marsToolStripMenuItem.Checked)
            {
                marsToolStripMenuItem.Checked = false;
                Refresh();
            }
            else
            {
                marsToolStripMenuItem.Checked = true;
                Refresh();
            }
        }

        private void crescentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (crescentToolStripMenuItem.Checked)
            {
                crescentToolStripMenuItem.Checked = false;
                Refresh();
            }
            else
            {
                crescentToolStripMenuItem.Checked = true;
                Refresh();
            }
        }
    }
}
