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
        Random _rd = new Random();
        Timer _oTimer = new Timer();
        bool _bTimer = false; // Timer switch

        public Form1()
        {
            InitializeComponent();

            // Set timer interval and event handler
            _oTimer.Interval = 2000;
            _oTimer.Tick += _oTimer_Tick;
        }

        private void Form1_Load(object sender, EventArgs e) { }
        private void label19_Click(object sender, EventArgs e) { }
        private void label18_Click(object sender, EventArgs e) { }
        private void label16_Click(object sender, EventArgs e) { }
        private void label14_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }

        private void btnDataIn_Click(object sender, EventArgs e)
        {
            int iData = _rd.Next(1, 101);

            // Insert data into the queue
            if (_Queue.Count < 6)
            {
                _Queue.Enqueue(iData);
                fDisplay(new Label[] { lblQueue1, lblQueue2, lblQueue3, lblQueue4, lblQueue5, lblQueue6 }, _Queue.ToArray());
            }

            // Push data into the stack
            if (_Stack.Count < 6)
            {
                _Stack.Push(iData);
                fDisplay(new Label[] { lblStack1, lblStack2, lblStack3, lblStack4, lblStack5, lblStack6 }, _Stack.ToArray());
            }
        }

        private void fDisplay(Label[] labels, int[] values)
        {
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i].Text = (i < values.Length) ? values[i].ToString() : "";
            }
        }

        private void btnDataOut_Click(object sender, EventArgs e)
        {
            fDataOut();
        }

        private void fDataOut()
        {
            if (_Queue.Count > 0)
                _Queue.Dequeue();

            if (_Stack.Count > 0)
                _Stack.Pop();

            fDisplay(new Label[] { lblQueue1, lblQueue2, lblQueue3, lblQueue4, lblQueue5, lblQueue6 }, _Queue.ToArray());
            fDisplay(new Label[] { lblStack1, lblStack2, lblStack3, lblStack4, lblStack5, lblStack6 }, _Stack.ToArray());
        }

        private void btnDataAutoOut_Click(object sender, EventArgs e)
        {
            if (_bTimer)
            {
                _oTimer.Stop();
                _bTimer = false;
            }
            else
            {
                _oTimer.Start();
                _bTimer = true;
            }
        }

        private void _oTimer_Tick(object sender, EventArgs e)
        {
            fDataOut();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e) { }
    }
}
