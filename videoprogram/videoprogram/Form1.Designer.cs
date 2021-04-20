
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
            this.pictureBox1.Image = global::videoprogram.Properties.Resources.gif2;
            this.pictureBox1.Location = new System.Drawing.Point(235, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 176);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 281);
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
    }
}

