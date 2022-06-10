using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(); // відкриття форми та скриття цієї форми
            form3.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(); // відкриття форми та скриття цієї форми
            form6.Show();
            this.Hide();


        }


        private void правилаToolStripMenuItem_Click_1(object sender, EventArgs e)
        {//Правила гри
            MessageBox.Show(
               "\nУ грі \"Бики та Корови\"  реалізовано два режими: \n\nГра з гравцем - кожен із суперників загадує чотиризначне число, " +
               "усі цифри якого різні (перша цифра числа відмінна від нуля). " +
               "Необхідно розгадати задумане число. " +
               "Перемагає той, хто відгадає перший. " +
               "Суперники по черзі називають друг другу числа i повідомляють про кількість Биків i Корів у названому числі " +
               "(Бик - цифра є в записі задуманого числа i стоїть у той самій позиції;  " +
               "Корова - цифра є в записі задуманого числа але не стоїть у той самій позиції, що i в задуманому числі); " +
               "\n\nГра з ПК - комп'ютер загадав для вас 4-х значне число, " +
                "усі цифри якого різні (перша цифра числа відмінна від нуля). " +
                "Необхідно відгадати задумане число. " +
                "Ви повинні називати число i ПК повідомить про кількість Биків i Корів у названому числі " +
                "(Бик - цифра є в записі задуманого числа i стоїть у той самій позиції;  " +
                "Корова - цифра є в записі задуманого числа але не стоїть у той самій позиції, що i в задуманому числі). ", "Правила", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void проГруToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {//видалення файлів після закриття гри
            System.IO.File.Delete(@"config.txt");
            System.IO.File.Delete(@"configPC.txt");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
