﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm_2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "Midterm";
            lblPass.ForeColor =Color.Red;
        }
        

        /*private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtPass.ForeColor = Color.Red;
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {
           /* MessageBox.Show("Hi Rama");*/
        }
    }
}
