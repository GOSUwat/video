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
        Button and = new Button();
        Button dtrigger = new Button();

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Hide();
            label1.Text = "Разбор работы Триггеров";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            int count = 0;
            int font;
            if (count == 0)
            {
                for (font = 60; font >= 25; font--)
                {
                    label1.Font = new Font("Microsoft Himalaya", font);
                    Thread.Sleep(10);
                }
                label1.Location = new Point(10, 30);
                Thread.Sleep(500);
                //pictureBox1.Show();
                count++;
            }
            else
            {
                for (font = 60; font >= 25; font--)
                {
                    label1.Font = new Font("Microsoft Himalaya", font);
                    Thread.Sleep(10);
                }
                label1.Location = new Point(10, 30);
                Thread.Sleep(500);
                count++;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Controls.Add(dtrigger);
            dtrigger.Location = button1.Location;
            dtrigger.Text = "Solve";
            dtrigger.Click += new EventHandler(dtrigger_Click);
            dtrigger.Hide();
            set.Hide();
            reset.Hide();
            or1.Hide();
            or2.Hide();
            q1.Hide();
            q2.Hide();
            Qb1.Hide();
            Qb2.Hide();
            resetb.Hide();
            setb.Hide();
            button1.Hide();
            this.Controls.Add(and);
            and.Location = button1.Location;
            and.Text = "Solve";
            and.Click += new EventHandler(and_Click);
            and.Hide();
        }

        private void hides()
        {
            set.Hide();
            reset.Hide();
            or1.Hide();
            or2.Hide();
            q1.Hide();
            q2.Hide();
            Qb1.Hide();
            Qb2.Hide();
            resetb.Hide();
            setb.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void асинхронныйРСТриггерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dtrigger.Hide();
            reset.Text = "R";
            set.Text = "S";
            or1.Text = "1";
            or2.Text = "1";
            hides();
            Qb1.Show();
            Qb2.Show();
            resetb.Show();
            setb.Show();
            button1.Show();
            pictureBox1.Show();
            label1.Text = "OR Async RS Trigger";
            label1.Show();
            int x = 3;
            Graphics g;
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bitmap);
            Pen penblck = new Pen(Color.Black, x);
            Pen penred = new Pen(Color.Red, x);
            Pen penblue = new Pen(Color.Blue, x);

            g.DrawRectangle(penblck, 300, 10, 50, 60); //Square R
            g.DrawRectangle(penblck, 300, 120, 50, 60); //Square S

            //Vhod R
            g.DrawLine(penred, 300, 30, 250, 30);
            //Vhod S
            g.DrawLine(penred, 300, 140, 250, 140);
            //Vihod R
            g.DrawLine(penred, 351, 30, 450, 30);
            g.DrawArc(penblck, 345, 25, 10, 10, 360, 360);
            //Vihod S
            g.DrawLine(penred, 351, 140, 450, 140);
            g.DrawArc(penblck, 345, 135, 10, 10, 360, 360);
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
            set.Show();
            reset.Show();
            or1.Show();
            or2.Show();
            q1.Show();
            q2.Show();
            pictureBox1.Image = bitmap;
        } //1

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "OR Async RS Trigger";
            label1.Show();
            int x = 3;
            Graphics g;
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bitmap);
            Pen penblck = new Pen(Color.Black, x);
            Pen penred = new Pen(Color.Red, x);
            Pen penblue = new Pen(Color.Blue, x);
            g.DrawArc(penblck, 345, 135, 10, 10, 360, 360);
            g.DrawArc(penblck, 345, 25, 10, 10, 360, 360);
            g.DrawRectangle(penblck, 300, 10, 50, 60); //Square R
            g.DrawRectangle(penblck, 300, 120, 50, 60); //Square S
            try
            {
                int setb1;
                int resetb1;
                setb1 = Convert.ToInt32(setb.Text);
                resetb1 = Convert.ToInt32(resetb.Text);

                if (((setb1 == 1) & (resetb1 == 1)) || (setb1 + resetb1 > 2))
                {
                    forma.Text = "Неверная Комбинация";
                }
                else if ((setb1 == 1) & (resetb1 == 0)) //SET = 1 RESET = 0
                {
                    g.DrawLine(penred, 300, 140, 250, 140);
                    g.DrawLine(penblue, 351, 140, 450, 140);

                    g.DrawLine(penblue, 380, 80, 380, 140);
                    g.DrawLine(penblue, 382, 80, 270, 80);
                    g.DrawLine(penblue, 270, 40, 270, 82);
                    g.DrawLine(penblue, 270, 40, 300, 40);

                    g.DrawLine(penred, 351, 30, 450, 30);

                    g.DrawLine(penred, 400, 30, 400, 90);
                    g.DrawLine(penred, 402, 90, 270, 90);
                    g.DrawLine(penred, 270, 90, 270, 130);
                    g.DrawLine(penred, 269, 130, 300, 130);

                    g.DrawLine(penblue, 300, 30, 250, 30);
                    Qb1.Text = ("1");
                    Qb2.Text = ("0");
                    forma.Text = "Запись 1";
                }

                else if ((setb1 == 0) & (resetb1 == 1)) //SET = 0 RESET = 1
                {
                    g.DrawLine(penblue, 300, 140, 250, 140);
                    g.DrawLine(penred, 351, 140, 450, 140);

                    g.DrawLine(penred, 380, 80, 380, 140);
                    g.DrawLine(penred, 382, 80, 270, 80);
                    g.DrawLine(penred, 270, 40, 270, 82);
                    g.DrawLine(penred, 270, 40, 300, 40);

                    g.DrawLine(penblue, 351, 30, 450, 30);

                    g.DrawLine(penblue, 400, 30, 400, 90);
                    g.DrawLine(penblue, 402, 90, 270, 90);
                    g.DrawLine(penblue, 270, 90, 270, 130);
                    g.DrawLine(penblue, 269, 130, 300, 130);

                    g.DrawLine(penred, 300, 30, 250, 30);

                    Qb1.Text = ("0");
                    Qb2.Text = ("1");
                    forma.Text = "Запись 0";
                }
                else
                {
                    forma.Text = "Хранение Информации";
                }

            }
            catch (Exception)
            {

            }
            pictureBox1.Image = bitmap;
        }

        private void дТриггерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "D Trigger";
            label1.BringToFront();
            hides();
            pictureBox1.Show();




        }

        private void асинхронныйРСТриггерToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            reset.Text = "S";
            set.Text = "R";
            or1.Text = "and";
            or2.Text = "and";
            button1.Hide();
            hides();
            Qb1.Show();
            Qb2.Show();
            resetb.Show();
            setb.Show();
            and.Show();
            pictureBox1.Show();
            label1.Text = "AND Async RS Trigger";
            label1.Show();
            int x = 3;
            Graphics g;
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bitmap);
            Pen penblck = new Pen(Color.Black, x);
            Pen penred = new Pen(Color.Red, x);
            Pen penblue = new Pen(Color.Blue, x);

            g.DrawRectangle(penblck, 300, 10, 50, 60); //Square R
            g.DrawRectangle(penblck, 300, 120, 50, 60); //Square S

            //Vhod R
            g.DrawLine(penred, 300, 30, 250, 30);
            //Vhod S
            g.DrawLine(penred, 300, 140, 250, 140);
            //Vihod R
            g.DrawLine(penred, 351, 30, 450, 30);
            g.DrawArc(penblck, 345, 25, 10, 10, 360, 360);
            //Vihod S
            g.DrawLine(penred, 351, 140, 450, 140);
            g.DrawArc(penblck, 345, 135, 10, 10, 360, 360);
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
            set.Show();
            reset.Show();
            or1.Show();
            or2.Show();
            q1.Show();
            q2.Show();
            pictureBox1.Image = bitmap;
        } //&

        private void and_Click(object sender, EventArgs e)
        {






            label1.Text = "AND Async RS Trigger";
            label1.Show();
            int x = 3;
            Graphics g;
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bitmap);
            Pen penblck = new Pen(Color.Black, x);
            Pen penred = new Pen(Color.Red, x);
            Pen penblue = new Pen(Color.Blue, x);
            g.DrawArc(penblck, 345, 135, 10, 10, 360, 360);
            g.DrawArc(penblck, 345, 25, 10, 10, 360, 360);
            g.DrawRectangle(penblck, 300, 10, 50, 60); //Square R
            g.DrawRectangle(penblck, 300, 120, 50, 60); //Square S
            try
            {
                int setb1;
                int resetb1;
                setb1 = Convert.ToInt32(setb.Text);
                resetb1 = Convert.ToInt32(resetb.Text);

                if (((setb1 == 1) & (resetb1 == 1)) || (setb1 + resetb1 > 2))
                {
                    forma.Text = "Неверная Комбинация";
                }
                else if ((setb1 == 0) & (resetb1 == 1)) //SET = 0 RESET = 1
                {
                    g.DrawLine(penblue, 300, 140, 250, 140);
                    g.DrawLine(penred, 351, 140, 450, 140);

                    g.DrawLine(penred, 380, 80, 380, 140);
                    g.DrawLine(penred, 382, 80, 270, 80);
                    g.DrawLine(penred, 270, 40, 270, 82);
                    g.DrawLine(penred, 270, 40, 300, 40);

                    g.DrawLine(penblue, 351, 30, 450, 30);

                    g.DrawLine(penblue, 400, 30, 400, 90);
                    g.DrawLine(penblue, 402, 90, 270, 90);
                    g.DrawLine(penblue, 270, 90, 270, 130);
                    g.DrawLine(penblue, 269, 130, 300, 130);

                    g.DrawLine(penred, 300, 30, 250, 30);
                    Qb1.Text = ("1");
                    Qb2.Text = ("0");
                    forma.Text = "Запись 1";
                }

                else if ((setb1 == 1) & (resetb1 == 0)) //SET = 1 RESET = 0
                {
                    g.DrawLine(penred, 300, 140, 250, 140);
                    g.DrawLine(penblue, 351, 140, 450, 140);

                    g.DrawLine(penblue, 380, 80, 380, 140);
                    g.DrawLine(penblue, 382, 80, 270, 80);
                    g.DrawLine(penblue, 270, 40, 270, 82);
                    g.DrawLine(penblue, 270, 40, 300, 40);

                    g.DrawLine(penred, 351, 30, 450, 30);

                    g.DrawLine(penred, 400, 30, 400, 90);
                    g.DrawLine(penred, 402, 90, 270, 90);
                    g.DrawLine(penred, 270, 90, 270, 130);
                    g.DrawLine(penred, 269, 130, 300, 130);

                    g.DrawLine(penblue, 300, 30, 250, 30);

                    Qb1.Text = ("0");
                    Qb2.Text = ("1");
                    forma.Text = "Запись 0";
                }
                else
                {
                    forma.Text = "Хранение Информации";
                }

            }
            catch (Exception)
            {

            }
            pictureBox1.Image = bitmap;
        }

        private void dtrigger_Click(object sender, EventArgs e)
        {

        }
    }
}
