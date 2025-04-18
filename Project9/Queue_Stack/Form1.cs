using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Queue_Stack
{
    public partial class Form1 : Form
    {
        Queue<int> _Queue = new Queue<int>(6);
        Stack<int> _Stack = new Stack<int>(6);
        Random _rd = new Random();
        Timer _oTimer = new Timer();
        bool _bTimer = false; // Timer 스위치

        public Form1()
        {
            InitializeComponent();
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

            // Queue에 Data를 입력
            if (_Queue.Count < 6)
            {
                _Queue.Enqueue(iData);
                fQueueDataDisplay();
            }

            // Stack에 Data를 입력
            if (_Stack.Count < 6)
            {
                _Stack.Push(iData);
                fStackDataDisplay();
            }
        }

        private void fQueueDataDisplay()
        {
            int[] iArray = _Queue.ToArray();
            Label[] labels = { lblQueue1, lblQueue2, lblQueue3, lblQueue4, lblQueue5, lblQueue6 };

            for (int i = 0; i < labels.Length; i++)
            {
                labels[i].Text = (i < iArray.Length && iArray[i] != 0) ? iArray[i].ToString() : "";
            }
        }

        private void fStackDataDisplay()
        {
            int[] iArray = _Stack.ToArray();
            Label[] labels = { lblStack1, lblStack2, lblStack3, lblStack4, lblStack5, lblStack6 };

            for (int i = 0; i < labels.Length; i++)
            {
                labels[i].Text = (i < iArray.Length && iArray[i] != 0) ? iArray[i].ToString() : "";
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

            fQueueDataDisplay();
            fStackDataDisplay();
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
                _oTimer.Interval = 2000;
                _oTimer.Tick -= _oTimer_Tick; // 중복 방지용 제거
                _oTimer.Tick += _oTimer_Tick;
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