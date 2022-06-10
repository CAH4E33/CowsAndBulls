using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 1)
            {
                MessageBox.Show("Поле з нікнеймом не може бути порожнім!", "Помилка"); //перевірка на пусте поле
                return;
            }

            if (textBox2.TextLength >= 4) //якщо число 4-х значне
            {


                string path = @"config.txt"; 
                int countd = 0;
                char[] tx2 = textBox2.Text.ToCharArray(); //занесення числа в символьний масив
                for (int i = 0; i <= 3; i++)
                {

                    for (int j = 0; j <= 3; j++)
                    {

                        if (tx2[i] == tx2[j])
                        {
                            countd++; //лічильник однакових цифр у числі

                        }


                    }

                }



                if (countd > 4) //неправильне ведення
                {
                    MessageBox.Show("Цифри у числі не повинні повторюватися!", "Помилка");
                    return;
                }

                else
                {

                    string lines = textBox1.Text + Environment.NewLine + textBox2.Text + Environment.NewLine;
                    File.WriteAllText(path, lines);

                    Form4 form4 = new Form4();
                    form4.Show();
                    this.Close(); //запис даних у документ та відкриття наступної форми

                }

            }

            else
            { //неправильне введення
                MessageBox.Show(
               "Число повинно бути 4-х значне",
               "Перший гравець",
                MessageBoxButtons.OK);
                return;



            }


        }


        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57)) //перевірка на правильність введення
                e.Handled = true;
        }


        //кнопка вихіду
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
            if (MessageBox.Show("Ви точно бажаете завершити гру та повернутись на головне меню?", "Завершення гри", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                Form1 form1 = (Form1)Application.OpenForms[0];
                form1.Show();
            }

        }

        //для переміщення форми
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {// скриття числа
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else { textBox2.PasswordChar = '●'; }
        }

    }
}
