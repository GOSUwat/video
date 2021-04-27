
namespace videoprogram
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tick1 = new System.Windows.Forms.Label();
            this.tick2 = new System.Windows.Forms.Label();
            this.tick3 = new System.Windows.Forms.Label();
            this.tick4 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Label();
            this.set = new System.Windows.Forms.Label();
            this.or1 = new System.Windows.Forms.Label();
            this.or2 = new System.Windows.Forms.Label();
            this.q1 = new System.Windows.Forms.Label();
            this.q2 = new System.Windows.Forms.Label();
            this.resetb = new System.Windows.Forms.TextBox();
            this.setb = new System.Windows.Forms.TextBox();
            this.Qb1 = new System.Windows.Forms.TextBox();
            this.Qb2 = new System.Windows.Forms.TextBox();
            this.forma = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Himalaya", 60.25F);
            this.label1.Location = new System.Drawing.Point(31, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(711, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "Асинхронный RS триггер";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(171, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(586, 210);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tick1
            // 
            this.tick1.AutoSize = true;
            this.tick1.Location = new System.Drawing.Point(194, 84);
            this.tick1.Name = "tick1";
            this.tick1.Size = new System.Drawing.Size(0, 13);
            this.tick1.TabIndex = 2;
            // 
            // tick2
            // 
            this.tick2.AutoSize = true;
            this.tick2.Location = new System.Drawing.Point(194, 228);
            this.tick2.Name = "tick2";
            this.tick2.Size = new System.Drawing.Size(0, 13);
            this.tick2.TabIndex = 3;
            // 
            // tick3
            // 
            this.tick3.AutoSize = true;
            this.tick3.Location = new System.Drawing.Point(496, 106);
            this.tick3.Name = "tick3";
            this.tick3.Size = new System.Drawing.Size(0, 13);
            this.tick3.TabIndex = 4;
            // 
            // tick4
            // 
            this.tick4.AutoSize = true;
            this.tick4.Location = new System.Drawing.Point(496, 216);
            this.tick4.Name = "tick4";
            this.tick4.Size = new System.Drawing.Size(0, 13);
            this.tick4.TabIndex = 5;
            // 
            // reset
            // 
            this.reset.AutoSize = true;
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.reset.Location = new System.Drawing.Point(422, 66);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(34, 31);
            this.reset.TabIndex = 6;
            this.reset.Text = "R";
            // 
            // set
            // 
            this.set.AutoSize = true;
            this.set.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.set.Location = new System.Drawing.Point(422, 228);
            this.set.Name = "set";
            this.set.Size = new System.Drawing.Size(32, 31);
            this.set.TabIndex = 7;
            this.set.Text = "S";
            // 
            // or1
            // 
            this.or1.AutoSize = true;
            this.or1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.or1.Location = new System.Drawing.Point(483, 100);
            this.or1.Name = "or1";
            this.or1.Size = new System.Drawing.Size(29, 31);
            this.or1.TabIndex = 8;
            this.or1.Text = "1";
            // 
            // or2
            // 
            this.or2.AutoSize = true;
            this.or2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.or2.Location = new System.Drawing.Point(483, 210);
            this.or2.Name = "or2";
            this.or2.Size = new System.Drawing.Size(29, 31);
            this.or2.TabIndex = 9;
            this.or2.Text = "1";
            // 
            // q1
            // 
            this.q1.AutoSize = true;
            this.q1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.q1.Location = new System.Drawing.Point(593, 66);
            this.q1.Name = "q1";
            this.q1.Size = new System.Drawing.Size(35, 31);
            this.q1.TabIndex = 10;
            this.q1.Text = "Q";
            // 
            // q2
            // 
            this.q2.AutoSize = true;
            this.q2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.q2.Location = new System.Drawing.Point(593, 175);
            this.q2.Name = "q2";
            this.q2.Size = new System.Drawing.Size(43, 31);
            this.q2.TabIndex = 11;
            this.q2.Text = "!Q";
            // 
            // resetb
            // 
            this.resetb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.resetb.Location = new System.Drawing.Point(356, 80);
            this.resetb.Name = "resetb";
            this.resetb.Size = new System.Drawing.Size(53, 29);
            this.resetb.TabIndex = 12;
            // 
            // setb
            // 
            this.setb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.setb.Location = new System.Drawing.Point(356, 210);
            this.setb.Name = "setb";
            this.setb.Size = new System.Drawing.Size(53, 29);
            this.setb.TabIndex = 13;
            // 
            // Qb1
            // 
            this.Qb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Qb1.Location = new System.Drawing.Point(631, 81);
            this.Qb1.Name = "Qb1";
            this.Qb1.Size = new System.Drawing.Size(53, 29);
            this.Qb1.TabIndex = 14;
            // 
            // Qb2
            // 
            this.Qb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Qb2.Location = new System.Drawing.Point(631, 210);
            this.Qb2.Name = "Qb2";
            this.Qb2.Size = new System.Drawing.Size(53, 29);
            this.Qb2.TabIndex = 15;
            // 
            // forma
            // 
            this.forma.AutoSize = true;
            this.forma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.forma.Location = new System.Drawing.Point(63, 140);
            this.forma.Name = "forma";
            this.forma.Size = new System.Drawing.Size(0, 25);
            this.forma.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 281);
            this.Controls.Add(this.forma);
            this.Controls.Add(this.Qb2);
            this.Controls.Add(this.Qb1);
            this.Controls.Add(this.setb);
            this.Controls.Add(this.resetb);
            this.Controls.Add(this.q2);
            this.Controls.Add(this.q1);
            this.Controls.Add(this.or2);
            this.Controls.Add(this.or1);
            this.Controls.Add(this.set);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.tick4);
            this.Controls.Add(this.tick3);
            this.Controls.Add(this.tick2);
            this.Controls.Add(this.tick1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "-_-";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label tick1;
        private System.Windows.Forms.Label tick2;
        private System.Windows.Forms.Label tick3;
        private System.Windows.Forms.Label tick4;
        private System.Windows.Forms.Label reset;
        private System.Windows.Forms.Label set;
        private System.Windows.Forms.Label or1;
        private System.Windows.Forms.Label or2;
        private System.Windows.Forms.Label q1;
        private System.Windows.Forms.Label q2;
        private System.Windows.Forms.TextBox resetb;
        private System.Windows.Forms.TextBox setb;
        private System.Windows.Forms.TextBox Qb1;
        private System.Windows.Forms.TextBox Qb2;
        private System.Windows.Forms.Label forma;
    }
}

