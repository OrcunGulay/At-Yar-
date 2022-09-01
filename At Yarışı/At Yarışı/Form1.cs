using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace At_Yarışı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int b,c,d,f;
        int say = 0;
        int topb, topc, topd, topf = 0;


        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            button1.Enabled = true;
            pictureBox1.Location = new Point(4, 20);
            pictureBox2.Location = new Point(4, 140);
            pictureBox6.Location = new Point(4, 260);
            pictureBox7.Location = new Point(4, 380);
            label5.Text = string.Empty;
            label8.Text = string.Empty;
          

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button1.Enabled = false;
            topb = 0;
            topc = 0;
            topd = 0;
            topf = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            say++;
            pictureBox1.Location = new Point(pictureBox1.Location.X + (b = rnd.Next(3, 25)), 20);
            pictureBox2.Location = new Point(pictureBox2.Location.X + (c = rnd.Next(3, 25)), 140);
            pictureBox6.Location = new Point(pictureBox6.Location.X + (d = rnd.Next(3, 25)), 260);
            pictureBox7.Location = new Point(pictureBox7.Location.X + (f = rnd.Next(3, 25)), 380);
            topb = topb + b;
            topc = topc + c;
            topd = topd + d;
            topf = topf + f;
           

            if (topb>topc && topb>topd && topb>topf)
            {
                label5.Text = "1. at önde";
            }
            if (topc > topb && topc > topd && topc > topf)
            {
                label5.Text = "2. at önde";
            }
            if (topd > topc && topd > topb && topd > topf)
            {
                label5.Text = "3. at önde";
            }
            if (topf > topc && topf > topd && topf > topb)
            {
                label5.Text = "4. at önde";
            }
            if (pictureBox1.Location.X >= 765){
                if (topb > topc && topb > topd && topb > topf)
                {
                timer1.Enabled = false;
                label5.Text="Gülkızı  oyunu kazandı!!!";
                }
            }
            if (pictureBox2.Location.X >= 765)
            {
                if (topc > topb && topc > topd && topc > topf)
                {
                    timer1.Enabled = false;
                    label5.Text = "Delgeç Mustafa oyunu kazandı!!!";
                }
            }
            if (pictureBox6.Location.X >= 765)
            {
                if (topd > topc && topd > topb && topd > topf)
                {
                timer1.Enabled = false;
                    label5.Text = "Dilaver at oyunu kazandı!!!";

                }
            }
            if (pictureBox7.Location.X >= 765)
            {
                if (topf > topc && topf > topd && topf > topb)
                {
                timer1.Enabled = false;
                    label5.Text = "Alacakaranlık oyunu kazandı!!!";

                }
            }
        }
    }
}