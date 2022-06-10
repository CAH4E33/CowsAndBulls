
namespace WindowsFormsApp1
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.but1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.правилаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.name1 = new System.Windows.Forms.Label();
            this.WinName = new System.Windows.Forms.Label();
            this.CloseBut = new System.Windows.Forms.Label();
            this.Border = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.Border.SuspendLayout();
            this.SuspendLayout();
            // 
            // but1
            // 
            this.but1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.but1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but1.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.but1.FlatAppearance.BorderSize = 2;
            this.but1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.but1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but1.Font = new System.Drawing.Font("Peace Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but1.ForeColor = System.Drawing.Color.Crimson;
            this.but1.Location = new System.Drawing.Point(132, 137);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(120, 34);
            this.but1.TabIndex = 13;
            this.but1.Text = "Ввести";
            this.but1.UseVisualStyleBackColor = false;
            this.but1.Click += new System.EventHandler(this.but1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(111, 94);
            this.textBox1.MaxLength = 4;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 32);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.правилаToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(138, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // правилаToolStripMenuItem
            // 
            this.правилаToolStripMenuItem.Name = "правилаToolStripMenuItem";
            this.правилаToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.правилаToolStripMenuItem.Text = "Правила";
            this.правилаToolStripMenuItem.Click += new System.EventHandler(this.правилаToolStripMenuItem_Click);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.вихідToolStripMenuItem.Text = "Про гру";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(141, 40);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(18, 22);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = "0";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(160, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(141, 128);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(18, 22);
            this.textBox4.TabIndex = 2;
            this.textBox4.Text = "0";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(160, 106);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Location = new System.Drawing.Point(0, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 204);
            this.panel1.TabIndex = 14;
            // 
            // name1
            // 
            this.name1.AutoSize = true;
            this.name1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.name1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.name1.Location = new System.Drawing.Point(111, 76);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(51, 20);
            this.name1.TabIndex = 15;
            this.name1.Text = "name1";
            this.name1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WinName
            // 
            this.WinName.AutoSize = true;
            this.WinName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WinName.ForeColor = System.Drawing.Color.White;
            this.WinName.Location = new System.Drawing.Point(12, 8);
            this.WinName.Name = "WinName";
            this.WinName.Size = new System.Drawing.Size(52, 13);
            this.WinName.TabIndex = 14;
            this.WinName.Text = "Гра с ПК";
            this.WinName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WinName_MouseDown);
            this.WinName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WinName_MouseMove);
            // 
            // CloseBut
            // 
            this.CloseBut.AutoSize = true;
            this.CloseBut.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CloseBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseBut.ForeColor = System.Drawing.Color.White;
            this.CloseBut.Location = new System.Drawing.Point(357, 3);
            this.CloseBut.Name = "CloseBut";
            this.CloseBut.Size = new System.Drawing.Size(24, 24);
            this.CloseBut.TabIndex = 12;
            this.CloseBut.Text = "X";
            this.CloseBut.Click += new System.EventHandler(this.CloseBut_Click);
            this.CloseBut.MouseEnter += new System.EventHandler(this.CloseBut_MouseEnter);
            this.CloseBut.MouseLeave += new System.EventHandler(this.CloseBut_MouseLeave);
            // 
            // Border
            // 
            this.Border.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Border.Controls.Add(this.WinName);
            this.Border.Controls.Add(this.CloseBut);
            this.Border.Location = new System.Drawing.Point(0, 0);
            this.Border.Name = "Border";
            this.Border.Size = new System.Drawing.Size(384, 30);
            this.Border.TabIndex = 16;
            this.Border.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Border_MouseDown);
            this.Border.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Border_MouseMove);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 420);
            this.Controls.Add(this.Border);
            this.Controls.Add(this.name1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.but1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Border.ResumeLayout(false);
            this.Border.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button but1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem правилаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        public System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label name1;
        private System.Windows.Forms.Label WinName;
        private System.Windows.Forms.Label CloseBut;
        private System.Windows.Forms.Panel Border;
    }
}