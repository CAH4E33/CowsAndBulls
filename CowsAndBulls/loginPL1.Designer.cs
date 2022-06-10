
namespace WindowsFormsApp1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CloseBut = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.WinName = new System.Windows.Forms.Label();
            this.Border = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.Border.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 148);
            this.button1.MaximumSize = new System.Drawing.Size(90, 33);
            this.button1.MinimumSize = new System.Drawing.Size(90, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Далі";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 50);
            this.textBox1.MaxLength = 8;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(97, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ім\'я гравця";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(100, 112);
            this.textBox2.MaxLength = 4;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '●';
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ваше загадане число";
            // 
            // CloseBut
            // 
            this.CloseBut.AutoSize = true;
            this.CloseBut.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CloseBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseBut.ForeColor = System.Drawing.Color.White;
            this.CloseBut.Location = new System.Drawing.Point(273, 4);
            this.CloseBut.Name = "CloseBut";
            this.CloseBut.Size = new System.Drawing.Size(24, 24);
            this.CloseBut.TabIndex = 12;
            this.CloseBut.Text = "X";
            this.CloseBut.Click += new System.EventHandler(this.CloseBut_Click);
            this.CloseBut.MouseEnter += new System.EventHandler(this.CloseBut_MouseEnter);
            this.CloseBut.MouseLeave += new System.EventHandler(this.CloseBut_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 220);
            this.panel1.TabIndex = 13;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(196, 158);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 16);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Показати число";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // WinName
            // 
            this.WinName.AutoSize = true;
            this.WinName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WinName.ForeColor = System.Drawing.Color.White;
            this.WinName.Location = new System.Drawing.Point(12, 9);
            this.WinName.Name = "WinName";
            this.WinName.Size = new System.Drawing.Size(91, 13);
            this.WinName.TabIndex = 14;
            this.WinName.Text = "Перший гравець";
            this.WinName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WinName_MouseDown);
            this.WinName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WinName_MouseMove);
            // 
            // Border
            // 
            this.Border.Controls.Add(this.WinName);
            this.Border.Controls.Add(this.CloseBut);
            this.Border.Location = new System.Drawing.Point(0, 0);
            this.Border.Name = "Border";
            this.Border.Size = new System.Drawing.Size(300, 30);
            this.Border.TabIndex = 14;
            this.Border.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Border_MouseDown);
            this.Border.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Border_MouseMove);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Border);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Перший гравець";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Border.ResumeLayout(false);
            this.Border.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label CloseBut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label WinName;
        private System.Windows.Forms.Panel Border;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}