﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataType_Study
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
            short snumber = 0;
            int inumber = 0;
            double dnumber = 0;
            long lnumber = 0;
            float fnumber = 0;
            label7.Text = "-";

            if (short.TryParse(textBox1.Text, out snumber))
            {
                label4.Text = snumber.ToString();
            }
            else if (int.TryParse(textBox1.Text, out inumber))
            {
                label6.Text = inumber.ToString();
            }
            else if (long.TryParse(textBox1.Text, out lnumber))
            {
                label8.Text = lnumber.ToString();
            }
            else if (double.TryParse(textBox1.Text, out dnumber)) // double 먼저 실행
            {
                if (float.TryParse(textBox1.Text, out fnumber))
                {
                    // float을 다시 double로 변환한 값과 원래 double 값 비교
                    if ((double)fnumber == dnumber)
                    {
                        label10.Text = fnumber.ToString(); // float 값 사용
                    }
                    else
                    {
                        label5.Text = dnumber.ToString(); // double 값 사용 (더 정밀)
                    }
                }
                else
                {
                    label5.Text = dnumber.ToString(); // float 변환 불가, double 사용
                }
            }
            else
            {
                label7.Text = "변환할 수 없음";
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}

