﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterace.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int age;
            try
            {
                age = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Enter number");
                return;
            }

            if (age>=18)
            {
                this.Show();

            int age = Convert.ToInt32(textBox1.Text);
            if (age>18)
            {
                this.Hide();

                var mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Еще юн");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Login from login form");
        }
    }
}
