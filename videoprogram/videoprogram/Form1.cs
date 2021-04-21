using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace videoprogram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //pictureBox1.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            /*for (int font = 60; font >= 25; font--)
            {
                label1.Font = new Font("Microsoft Himalaya", font);
                Thread.Sleep(10);
            }
            label1.Location = new Point(10, 10);
            Thread.Sleep(500);*/
            pictureBox1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //pictureBox1.BackColor = Color.White;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            draw();




        }
        private void draw()
        {
            int x = 3;
            Graphics g;
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bitmap);
            Pen penblck = new Pen(Color.Black,x);
            Pen penred = new Pen(Color.Red,x);
            Pen penblue = new Pen(Color.Blue,x);
            
            g.DrawRectangle(penblck, 300, 10, 50, 60); //Square R
            g.DrawRectangle(penblck, 300, 120, 50, 60); //Square S

            //Vhod R
            g.DrawLine(penred,300,30,250,30);
            //Vhod S
            g.DrawLine(penred, 300, 140, 250, 140);
            //Vihod R
            g.DrawLine(penred, 351, 30, 450, 30);
            //Vihod S
            g.DrawLine(penred, 351, 140, 450, 140);
            //R to S
            g.DrawLine(penblue, 400, 30, 400, 90);
            g.DrawLine(penblue, 402, 90, 270, 90);
            g.DrawLine(penblue, 270, 90, 270, 130);
            g.DrawLine(penblue, 269, 130, 300, 130);
            //S to R
            g.DrawLine(penred, 380, 80, 380, 140);
            g.DrawLine(penred, 382, 80, 270, 80);
            g.DrawLine(penred, 270, 40, 270, 82);
            g.DrawLine(penred, 270, 40, 300, 40);

            pictureBox1.Image = bitmap;
        }
    }
}
