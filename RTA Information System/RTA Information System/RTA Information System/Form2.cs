﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTA_Information_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            /*Form1 frm1 = new Form1();
            frm1.Show();*/
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            frm8.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form9 frm9 = new Form9();
            frm9.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form12 frm12 = new Form12();
            frm12.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form10 frm10 = new Form10();
            frm10.Show();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            Form11 frm11 = new Form11();
            frm11.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            challan_payment challan = new challan_payment();
            challan.Show();
        }
    }
}
