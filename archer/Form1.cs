using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace archer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void player1_TextChanged(object sender, EventArgs e)
        {
            player1label.Text = player1name.Text;
        }

        private void player2label_TextChanged(object sender, EventArgs e)
        {
            player2label.Text = player2name.Text;
        }
        int counter = 1;
        int countershots = 0;
        private void START_Click(object sender, EventArgs e)
        {
            Archer player1 = new Archer(player1name.Text, (int)numericUpDown1.Value);
            Archer player2 = new Archer(player1name.Text, (int)numericUpDown1.Value);
            countershots = Math.Abs((int)numericUpDown1.Value);
            hpplayer1.Text = (player1.LifePercent);
            attackplayer1.Text = player1.Attack;
            hpplayer2.Text = (player2.LifePercent);
            attackplayer2.Text = player2.Attack;
            radioButton1.Checked = true;
            player1name.Enabled = false;
            player2name.Enabled = false;
            numericUpDown1.Enabled = false;
            timer1.Interval = 10000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton2.Checked = true;
                radioButton1.Checked = false;
                fight.Enabled = false;
                fight1.Enabled = true;
                countershots -= 1;
            }
            else
            {
                radioButton2.Checked = false;
                radioButton1.Checked = true;
                fight1.Enabled = false;
                fight.Enabled = true;
                countershots -= 1;
            }
            if (countershots == 0 || )
            {
                timer1.Stop();

            }
            label8.Text = $"{countershots}";
        }
        int counterfight = 0;
        int counterclicks = 0;
        private void fight_Click(object sender, EventArgs e)
        {
            counterclicks++;
        }
        int countclicks1 = 0;
        private void fight1_Click(object sender, EventArgs e)
        {
            countclicks1++;
        }
    }
}
