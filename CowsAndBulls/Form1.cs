﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
                        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ХЗ!!! Творча пауза! Скоро!");
        }
    }
}
