﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace paint
{
    public partial class Form2 : Form
    {
        RadiusEventArgs radiusEventArgs = new RadiusEventArgs(12);
        //public event RadiusEventArgs
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            radiusEventArgs.RadiusChanged(this, new RadiusEventArgs(trackBar1.Value));
            radiusEventArgs.RadiusChanged += new RadiusEventArgs(trackBar1.Value)
        }
    }
}