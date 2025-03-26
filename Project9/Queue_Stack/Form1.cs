using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queue_Stack
{
    public partial class Form1 : Form
    {

        Queue<int> _Queue = new Queue<int>(6);
        Stack<int> _Stack = new Stack<int>(6);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDataIn_Click(object sender, EventArgs e)
        {
            Random rd  = new Random();
            int iData = rd.Next(1, 101);

            //Queue에 Data를 입력
            if(_Queue.Count < 6)
            {
                _Queue.Enqueue(iData);

            }

            //Stack에 Data를 입력
            if(_Stack.Count < 6) 
            {
             _Stack.Push(iData);

            }
        }
    }
}
