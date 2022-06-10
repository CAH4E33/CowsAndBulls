using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 1)
            {
                MessageBox.Show("Поле з нікнеймом не може бути порожнім!", "Помилка");
                return;
            }


            string path = @"configPC.txt";
            string lines = textBox1.Text + Environment.NewLine;
            File.WriteAllText(path, lines);



            Form5 form5 = new Form5();
            form5.Show();
            this.Close();
            MessageBox.Show(
              "Комп'ютер загадав рандомне число.\n" +
              "Cпробуй відгадати його!",
              "БикиТаКорови",
              MessageBoxButtons.OK);

        }

        private void CloseBut_MouseEnter(object sender, EventArgs e)
        {
            CloseBut.BackColor = Color.Red;
        }

        private void CloseBut_MouseLeave(object sender, EventArgs e)
        {
            CloseBut.BackColor = Color.FromArgb(105, 105, 105);
        }

        private void CloseBut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви точно бажаете завершити гру та повернутись на головне меню?",
                "Завершення гри",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                Form1 form1 = (Form1)Application.OpenForms[0];
                form1.Show();
            }
        }

        Point lastpoint;
        private void Border_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void Border_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void WinName_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void WinName_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

    }
}
