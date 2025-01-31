using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Loop
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

        private void btnFor_Click(object sender, EventArgs e)
        {
            testboxResult.Text = string.Empty;
            StringBuilder sb = new StringBuilder();
            int iResult = 0;
            for (int i = 1; i < 101; i++)
            {
                iResult += i;
                sb.Append(string.Format("1에서 {0}까지 더하면 {1}\r\n", i, iResult));
            }

            testboxResult.Text = sb.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void btnForeach_Click(object sender, EventArgs e)
        {
            testboxResult.Text = string.Empty;
            string[] arr = {"주연", "시율", "재형", "민준", "현수", "원빈", "진솔", "용재"};
            StringBuilder sb = new StringBuilder();
            int i = 0;
            foreach (var item in arr)
            {
                sb.Append(string.Format("{0} 선생님은 {1}반입니다.\r\n", item, i++));
            }

            testboxResult.Text = sb.ToString();
        }
    }
}
