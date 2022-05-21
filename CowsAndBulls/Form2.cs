using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            string path = @"config.txt";
            string[] readText = File.ReadAllLines(path);
            name1.Text = readText[0];
            name2.Text = readText[2];

        }

        private void Form2_Load(object sender, EventArgs e)
        {




        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = (Form1)Application.OpenForms[0];
            form1.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.TextLength >= 4)
            {


                string path = @"config.txt";
                string[] readText = File.ReadAllLines(path);



                int countd = 0;
                char[] tx1 = textBox1.Text.ToCharArray();
                char[] CH = readText[3].ToCharArray();
                textBox1.Clear();

                for (int i = 0; i <= 3; i++)
                {

                    for (int j = 0; j <= 3; j++)
                    {

                        if (tx1[i] == tx1[j])
                        {
                            countd++;

                        }


                    }

                }



                if (countd > 4)
                {
                    MessageBox.Show("Числа повторяються!");
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

                            countbulls++;

                        }
                    }


                    for (int i = 0; i <= 3; i++)
                    {

                        for (int j = 0; j <= 3; j++)
                        {

                            if (tx1[i] == CH[j])
                            {
                                countcow++;

                            }


                        }

                    }

                    textBox3.Text = Convert.ToString(countbulls);
                    textBox4.Text = Convert.ToString(countcow);

                    if (countbulls >= 4)
                    {
                        MessageBox.Show(
                        "ТИ ВГАДАВ!!!\n" + "Загадане число другого гравця: " + readText[3] + "\nВаше загадане число: " + readText[1],
                        "Другий гравець",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );



                    }
                }

            }
            else
            {
                MessageBox.Show(
                "Число повинно бути 4-х значне",
                "Перший гравець",
                MessageBoxButtons.OK);
                return;

            }

        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.TextLength >= 4)
            {


                string path = @"config.txt";
                string[] readText = File.ReadAllLines(path);



                int countd = 0;
                char[] tx2 = textBox2.Text.ToCharArray();
                char[] CH = readText[1].ToCharArray();
                textBox2.Clear();

                for (int i = 0; i <= 3; i++)
                {

                    for (int j = 0; j <= 3; j++)
                    {

                        if (tx2[i] == tx2[j])
                        {
                            countd++;

                        }


                    }

                }



                if (countd > 4)
                {
                    MessageBox.Show("Числа повторяються!");
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

                            countbulls++;

                        }
                    }


                    for (int i = 0; i <= 3; i++)
                    {

                        for (int j = 0; j <= 3; j++)
                        {

                            if (tx2[i] == CH[j])
                            {
                                countcow++;

                            }


                        }

                    }

                    textBox5.Text = Convert.ToString(countbulls);
                    textBox6.Text = Convert.ToString(countcow);

                    if (countbulls >= 4)
                    {
                        MessageBox.Show(
                        "ТИ ВГАДАВ!!!\n" + "Загадане число першого гравця: " + readText[1] + "\nВаше загадане число: " + readText[3],
                        "Другий гравець",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );




                    }
                }

            }
            else
            {
                MessageBox.Show(
                "Число повинно бути 4-х значне",
                "Другий гравець",
                MessageBoxButtons.OK);
                return;

            }


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void name1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            //textBox1.Clear();
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            //textBox2.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Ви точно бажаете завершити гру та повернутись на головне меню?", "Завершення гри", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
            { 
                e.Cancel = true; 
            }
            else
            {
                e.Cancel = false;
                Form1 form1 = (Form1)Application.OpenForms[0];
                form1.Show();
            }
        }

        private void правилаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Правила про гру Правила про гру Правила про гру Правила про гру Правила про гру Правила про гру", "Правила", MessageBoxButtons.OK, MessageBoxIcon.Information );
        }
    }
}
