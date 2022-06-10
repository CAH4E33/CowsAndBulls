﻿using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

        }

        // відкриття документа та зчитування даних

        private void Form5_Load(object sender, EventArgs e)
        {   // генерація рандомного числа при завантажені форми
            string path = @"configPC.txt";
            string[] readText = File.ReadAllLines(path);
            Random rand = new Random();
            int countd;
            string rnd;
            name1.Text = readText[0];


            do
            {
                countd = 0;
                rnd = Convert.ToString(rand.Next(1234, 9876));
                char[] PC = rnd.ToCharArray();

                for (int i = 0; i <= 3; i++)
                {

                    for (int j = 0; j <= 3; j++)
                    {

                        if (PC[i] == PC[j])
                        {
                            countd++;


                        }


                    }

                }
            } while (countd > 4); // герерація числа поки не буде виконана умова

            File.AppendAllText(path, rnd); //запис числа у документ


        }


        private void but1_Click(object sender, EventArgs e)
        {

            if (textBox1.TextLength >= 4) // перевірка на правильність введення
            {
                string[] readText = File.ReadAllLines(@"configPC.txt");
                
                int countd = 0;
                char[] tx1 = textBox1.Text.ToCharArray();
                char[] PC = readText[1].ToCharArray();
                textBox1.Clear();

                for (int i = 0; i <= 3; i++)
                {

                    for (int j = 0; j <= 3; j++)
                    {

                        if (tx1[i] == tx1[j])
                        {
                            countd++;           // перевірка на однакові цифри у числі

                        }


                    }

                }



                if (countd > 4)
                {
                    MessageBox.Show("Цифри у числі повторюються!", "Другий гравець", MessageBoxButtons.OK, MessageBoxIcon.Error); //якщо неправильне введення
                    return;
                }


                else //якщо правильне введення
                {
                    int countbulls = 0;
                    int countcow = 0;


                    for (int j = 0; j <= 3; j++)
                    {


                        if (tx1[j] == PC[j])
                        {

                            countbulls++; // підрахунок биків у числі

                        }
                    }


                    for (int i = 0; i <= 3; i++)
                    {

                        for (int j = 0; j <= 3; j++)
                        {

                            if (tx1[i] == PC[j])
                            {
                                countcow++; // підрахунок корів у числі

                            }


                        }

                    }

                    textBox3.Text = Convert.ToString(countbulls);
                    textBox4.Text = Convert.ToString(countcow);

                    if (countbulls >= 4) //перевірка на перемогу
                    {
                        DialogResult res = MessageBox.Show(
                        "-----ТИ ВГАДАВ!!!-----\n" + "Загадане число ПК: " + readText[1] + "\nГру завершено. " + "Ви будете повернені на головне меню!",
                        "Перший гравець",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information // повідомлення про перемогу
                        );
                        if (res == DialogResult.OK)
                        {
                            this.Close();
                            Form1 form1 = (Form1)Application.OpenForms[0];
                            form1.Show();   // закриття форми та повернення на головну форму після закінчення гри
                        }



                    }
                }

            }
            else //неправильне введення
            {
                MessageBox.Show(
                "Число повинно бути 4-х значне",
                "Другий гравець",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

        }

        private void правилаToolStripMenuItem_Click(object sender, EventArgs e)
        {// правила гри
            MessageBox.Show("Комп'ютер загадав для вас 4-х значне число, " +
                "усі цифри якого різні (перша цифра числа відмінна від нуля). " +
                "Необхідно відгадати задумане число. " +
                "Ви повинні називати число i ПК повідомить про кількість Биків i Корів у названому числі " +
                "(Бик - цифра є в записі задуманого числа i стоїть у той самій позиції;  " +
                "Корова - цифра є в записі задуманого числа але не стоїть у той самій позиції, що i в задуманому числі). ", "Правила", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {// про гру
            MessageBox.Show(
                "------------------------Бики та корови------------------------\n" +
                "Логічна гра, призначена для двох гравців, в основі якої закладено вгадування числа, задуманого суперником.\n" +
                "Версія гри: 1.0\n" +
                "Дата виходу версії: 23.05.22\n" +
                "Розробник: Студент 25 групи, Брюханов Олександр\n" +
                "Для курсової роботи по програмуванню!",
                "Про гру",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }


        //кнопка вихіду
        private void CloseBut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви точно бажаете завершити гру та повернутись на головне меню?",
                "Завершення гри",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                Form1 form1 = (Form1)Application.OpenForms[0];
                form1.Show(); // закриття форми та повернення на головну форму 
            }
        }

        private void CloseBut_MouseEnter(object sender, EventArgs e)
        {
            CloseBut.BackColor = Color.Red;
        }

        private void CloseBut_MouseLeave(object sender, EventArgs e)
        {
            CloseBut.BackColor = Color.FromArgb(105, 105, 105);
        }

        // для переміщення вікна
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57)) // перевірка на правильність введення
                e.Handled = true;
        }
    }

}
