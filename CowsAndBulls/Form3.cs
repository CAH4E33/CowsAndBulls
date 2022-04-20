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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox2.TextLength >= 4)
            {

                string path = @"config.txt";
                int countd = 0;
                char[] tx2 = textBox2.Text.ToCharArray();
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
                    MessageBox.Show("Цифри у числі не повинні повторюватися!", "Помилка");
                    return;
                }

                else
                {

                    string lines = textBox1.Text + Environment.NewLine + textBox2.Text + Environment.NewLine;
                    File.WriteAllText(path, lines);

                    Form4 form4 = new Form4();
                    form4.Show();
                    this.Close();
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }
    }
}
