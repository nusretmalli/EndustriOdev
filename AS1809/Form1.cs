﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS1809
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
        String id = "AS123";
        int password = 123;
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == id && Convert.ToInt32(textBox2.Text) == password)
            {
                    Form2 ff = new Form2();
                    ff.Show();
                    this.Hide();
            }
            else
            {
                label3.Visible = true;
            }
        } }
    }


