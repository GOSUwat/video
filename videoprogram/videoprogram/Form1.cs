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
            pictureBox1.Image = Image.FromFile("C:/Users/NANI/Desktop/videoprogram/video/videoprogram/videostuff/gif2.gif");
            pictureBox1.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            for (int font = 60; font >= 25; font--)
            {
                label1.Font = new Font("Microsoft Himalaya", font);
                Thread.Sleep(10);
            }
            label1.Location = new Point(10, 10);
            Thread.Sleep(500);
            pictureBox1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Thread ttiking = new Thread(new ThreadStart(tiking));
            
        }
        public static void tiking()
        {
            Form1.

        }
    }
}
