using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();


        }

        string[] readText = File.ReadAllLines(@"config.txt"); //Зчитування всіх рядків з документа

        private void Form2_Load(object sender, EventArgs e)
        {

            name1.Text = readText[0];       //Встановлення нікнеймів гравців при загрузці форми
            name2.Text = readText[2];

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 4)  //якщо число 4-х значне
            {


                int countd = 0;
                char[] tx1 = textBox1.Text.ToCharArray(); //занесення чисел в символьний масив
                char[] CH = readText[3].ToCharArray();
                textBox1.Clear();

                for (int i = 0; i <= 3; i++)
                {

                    for (int j = 0; j <= 3; j++)
                    {

                        if (tx1[i] == tx1[j])
                        {
                            countd++;               //підрахунок однакових цифр у введеному числі

                        }


                    }

                }



                if (countd > 4)
                {
                    MessageBox.Show("Цифри у числі повторюються!", "Перший гравець", MessageBoxButtons.OK, MessageBoxIcon.Error); //якщо неправильне введення
                    return;
                }


                else
                {
                    int countbulls = 0;
                    int countcow = 0;


                    for (int j = 0; j <= 3; j++)
                    {


                        if (tx1[j] == CH[j])
                        {

                            countbulls++; //підрахунок биків у числі

                        }
                    }


                    for (int i = 0; i <= 3; i++)
                    {

                        for (int j = 0; j <= 3; j++)
                        {

                            if (tx1[i] == CH[j])
                            {
                                countcow++; //підрахунок корів у числі

                            }


                        }

                    }

                    textBox3.Text = Convert.ToString(countbulls); //виведення кількість биків на екран
                    textBox4.Text = Convert.ToString(countcow); //виведення кількість корів на екран

                    if (countbulls >= 4) // умова для перемоги
                    {
                        DialogResult res = MessageBox.Show(
                        "-----ТИ ВГАДАВ!!!-----\n" + "Загадане число гравця " + name2.Text + ": " + readText[3] + "\nВаше загадане число: " + readText[1] + "\nГру завершено. " + "Ви будете повернені на головне меню!",
                        "" + name1.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information         //Повідомлення про перемогу
                        );

                        if (res == DialogResult.OK)
                        {
                            this.Close();
                            Form1 form1 = (Form1)Application.OpenForms[0]; //повернення на головну форму
                            form1.Show();

                        }
                        else
                        {
                            this.Close();
                            Form1 form1 = (Form1)Application.OpenForms[0]; // повернення на головну форму
                            form1.Show();
                        }



                    }
                }

            }
            else
            {
                MessageBox.Show(                        //повідомлення про неправильне введення
                "Число повинно бути 4-х значне",
                "Перший гравець",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.TextLength == 4) //якщо число 4-х значне
            {

                int countd = 0;
                char[] tx2 = textBox2.Text.ToCharArray(); //занесення чисел в символьний масив
                char[] CH = readText[1].ToCharArray();
                textBox2.Clear();

                for (int i = 0; i <= 3; i++)
                {

                    for (int j = 0; j <= 3; j++)
                    {

                        if (tx2[i] == tx2[j])
                        {
                            countd++;  //підрахунок однакових цифр у введеному числі

                        }


                    }

                }

                if (countd > 4)
                {
                    MessageBox.Show("Цифри у числі повторюються!", "Другий гравець", MessageBoxButtons.OK, MessageBoxIcon.Error); //якщо неправильне введення
                    return;
                }


                else
                {
                    int countbulls = 0;
                    int countcow = 0;


                    for (int j = 0; j <= 3; j++)
                    {


                        if (tx2[j] == CH[j])
                        {

                            countbulls++; //підрахунок биків у числі

                        }
                    }


                    for (int i = 0; i <= 3; i++)
                    {

                        for (int j = 0; j <= 3; j++)
                        {

                            if (tx2[i] == CH[j])
                            {
                                countcow++; //підрахунок корів у числі

                            }


                        }

                    }

                    textBox5.Text = Convert.ToString(countbulls); //виведення кількість биків на екран
                    textBox6.Text = Convert.ToString(countcow); //виведення кількість корів на екран

                    if (countbulls >= 4) // умова для перемоги
                    {
                        DialogResult res = MessageBox.Show(
                        "ТИ ВГАДАВ!!!\n" + "Загадане число гравця " + name1.Text + ": " + readText[1] + "\nВаше загадане число: " + readText[3] + "\nГру завершено. " + "Ви будете повернені на головне меню!",
                        "" + name2.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information //Повідомлення про перемогу
                        );

                        if (res == DialogResult.OK)
                        {
                            this.Close();
                            Form1 form1 = (Form1)Application.OpenForms[0]; //повернення на головну форму
                            form1.Show();

                        }
                        else
                        {
                            this.Close();
                            Form1 form1 = (Form1)Application.OpenForms[0]; //повернення на головну форму
                            form1.Show();
                        }


                    }
                }

            }
            else
            {
                MessageBox.Show(
                "Число повинно бути 4-х значне",
                "Другий гравець",
                MessageBoxButtons.OK, MessageBoxIcon.Error); //повідомлення про неправильне введення
                return;

            }


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57)) // перевірка на правильність введення
                e.Handled = true;
        }

        private void правилаToolStripMenuItem_Click(object sender, EventArgs e)
        {// правила
            MessageBox.Show("Кожен із суперників загадує чотиризначне число, " +
                "усі цифри якого різні (перша цифра числа відмінна від нуля). " +
                "Необхідно відгадати задумане число. " +
                "Перемагає той, хто відгадає перший. " +
                "Суперники по черзі називають друг другу числа i повідомляють про кількість Биків i Корів у названому числі " +
                "(Бик - цифра є в записі задуманого числа i стоїть у той самій позиції;  " +
                "Корова - цифра є в записі задуманого числа але не стоїть у той самій позиції, що i в задуманому числі). ", "Правила", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57)) // перевірка на правильність введення
                e.Handled = true;
        }

        private void ПрогруToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void CloseBut_MouseEnter(object sender, EventArgs e)
        {//кнопка вихіду
            CloseBut.BackColor = Color.Red;
        }

        private void CloseBut_MouseLeave(object sender, EventArgs e)
        {//кнопка вихіду
            CloseBut.BackColor = Color.FromArgb(105, 105, 105);
        }

        private void CloseBut_Click(object sender, EventArgs e)
        {//кнопка вихіду
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



        //для переміщення форми
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
