
namespace WindowsFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.but1 = new System.Windows.Forms.Button();
            this.правилаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.name2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Border = new System.Windows.Forms.Panel();
            this.WinName = new System.Windows.Forms.Label();
            this.CloseBut = new System.Windows.Forms.Label();
            this.name1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.Border.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(70, 110);
            this.textBox1.MaxLength = 4;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 32);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // but1
            // 
            this.but1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.but1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.but1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but1.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.but1.FlatAppearance.BorderSize = 2;
            this.but1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.but1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but1.Font = new System.Drawing.Font("Peace Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but1.ForeColor = System.Drawing.Color.Crimson;
            this.but1.Location = new System.Drawing.Point(91, 148);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(120, 34);
            this.but1.TabIndex = 5;
            this.but1.Text = "Ввести";
            this.but1.UseVisualStyleBackColor = false;
            this.but1.Click += new System.EventHandler(this.button1_Click_1);
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
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.ПрогруToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.правилаToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 33);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(138, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(777, -24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "X";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(508, 110);
            this.textBox2.MaxLength = 4;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(162, 32);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(100, 42);
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
            this.pictureBox1.Location = new System.Drawing.Point(119, 21);
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
            this.textBox4.Location = new System.Drawing.Point(100, 130);
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
            this.pictureBox2.Location = new System.Drawing.Point(119, 109);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(622, 42);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(18, 22);
            this.textBox5.TabIndex = 5;
            this.textBox5.Text = "0";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(557, 109);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 64);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox6.Location = new System.Drawing.Point(622, 130);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(18, 22);
            this.textBox6.TabIndex = 7;
            this.textBox6.Text = "0";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Location = new System.Drawing.Point(0, 222);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 196);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(557, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // name2
            // 
            this.name2.AutoSize = true;
            this.name2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.name2.Location = new System.Drawing.Point(508, 92);
            this.name2.Name = "name2";
            this.name2.Size = new System.Drawing.Size(53, 20);
            this.name2.TabIndex = 10;
            this.name2.Text = "name2";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Peace Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Crimson;
            this.button2.Location = new System.Drawing.Point(529, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 34);
            this.button2.TabIndex = 8;
            this.button2.Text = "Ввести";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Border
            // 
            this.Border.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Border.Controls.Add(this.WinName);
            this.Border.Controls.Add(this.CloseBut);
            this.Border.Location = new System.Drawing.Point(0, 0);
            this.Border.Name = "Border";
            this.Border.Size = new System.Drawing.Size(740, 30);
            this.Border.TabIndex = 15;
            this.Border.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Border_MouseDown);
            this.Border.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Border_MouseMove);
            // 
            // WinName
            // 
            this.WinName.AutoSize = true;
            this.WinName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WinName.ForeColor = System.Drawing.Color.White;
            this.WinName.Location = new System.Drawing.Point(12, 7);
            this.WinName.Name = "WinName";
            this.WinName.Size = new System.Drawing.Size(80, 13);
            this.WinName.TabIndex = 14;
            this.WinName.Text = "Гра з гравцем";
            this.WinName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WinName_MouseDown);
            this.WinName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WinName_MouseMove);
            // 
            // CloseBut
            // 
            this.CloseBut.AutoSize = true;
            this.CloseBut.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CloseBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseBut.ForeColor = System.Drawing.Color.White;
            this.CloseBut.Location = new System.Drawing.Point(713, 3);
            this.CloseBut.Name = "CloseBut";
            this.CloseBut.Size = new System.Drawing.Size(24, 24);
            this.CloseBut.TabIndex = 12;
            this.CloseBut.Text = "X";
            this.CloseBut.Click += new System.EventHandler(this.CloseBut_Click);
            this.CloseBut.MouseEnter += new System.EventHandler(this.CloseBut_MouseEnter);
            this.CloseBut.MouseLeave += new System.EventHandler(this.CloseBut_MouseLeave);
            // 
            // name1
            // 
            this.name1.AutoSize = true;
            this.name1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.name1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.name1.Location = new System.Drawing.Point(70, 92);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(51, 20);
            this.name1.TabIndex = 9;
            this.name1.Text = "name1";
            this.name1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(740, 418);
            this.Controls.Add(this.Border);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name2);
            this.Controls.Add(this.name1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.but1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Гра с кентом";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.Border.ResumeLayout(false);
            this.Border.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button but1;
        private System.Windows.Forms.ToolStripMenuItem правилаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Label name2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel Border;
        private System.Windows.Forms.Label WinName;
        private System.Windows.Forms.Label CloseBut;
        public System.Windows.Forms.Label name1;
    }
}