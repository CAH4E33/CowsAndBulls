
namespace WindowsFormsApp1
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.WinName = new System.Windows.Forms.Label();
            this.CloseBut = new System.Windows.Forms.Label();
            this.Border = new System.Windows.Forms.Panel();
            this.Border.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(90, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ім\'я гравця";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 98);
            this.textBox1.MaxLength = 8;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 140);
            this.button1.MaximumSize = new System.Drawing.Size(90, 33);
            this.button1.MinimumSize = new System.Drawing.Size(90, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Далі";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WinName
            // 
            this.WinName.AutoSize = true;
            this.WinName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WinName.ForeColor = System.Drawing.Color.White;
            this.WinName.Location = new System.Drawing.Point(12, 8);
            this.WinName.Name = "WinName";
            this.WinName.Size = new System.Drawing.Size(63, 13);
            this.WinName.TabIndex = 14;
            this.WinName.Text = "Грати с ПК";
            this.WinName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WinName_MouseDown);
            this.WinName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WinName_MouseMove);
            // 
            // CloseBut
            // 
            this.CloseBut.AutoSize = true;
            this.CloseBut.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CloseBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseBut.ForeColor = System.Drawing.Color.White;
            this.CloseBut.Location = new System.Drawing.Point(253, 3);
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
            this.Border.Size = new System.Drawing.Size(280, 30);
            this.Border.TabIndex = 16;
            this.Border.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Border_MouseDown);
            this.Border.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Border_MouseMove);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 240);
            this.Controls.Add(this.Border);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.Border.ResumeLayout(false);
            this.Border.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label WinName;
        private System.Windows.Forms.Label CloseBut;
        private System.Windows.Forms.Panel Border;
    }
}