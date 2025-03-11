using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker_Game
{
    public partial class Form1 : Form

    {
        private double iTick = 0;
        private double iTotal = 0;

        private int i1Add = 1;
        private int i1Level = 1;

        private int i5Add = 3;
        private int i5Level = 1;

        private int i50Add = 0;
        private int i50Level = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer oTimer = new Timer();
            oTimer.Enabled = true;
            oTimer.Interval = 100;
            oTimer.Tick += OTimer_Tick;
            oTimer.Start();
        }

        //타이머에서 호출 할 Event (Interval 간격 기준)
        private void OTimer_Tick(object sender, EventArgs e)
        {
            iTick = i1Add + i5Add + i50Add;
            iTotal += iTick;

            lblTickPoint.Text = string.Format("{0} (1:{1}), (5:{2}), (50:{3})", iTick.ToString(), i1Level.ToString(), i5Level.ToString(), i50Level.ToString());
            lblTotal.Text = iTotal.ToString();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string dd = string.Empty;
            Button obtn = sender as Button;
            switch (obtn.Name)
            {
                case "btn1Add":
                    if(iTotal > 100)
                    {
                        iTotal = iTotal - 100;

                        i1Level++;
                        i1Add = 1 * i1Level;

                    }
                    break;
                case "btn5Add":
                    if (iTotal > 500)
                    {
                        iTotal = iTotal - 500;

                        i5Level++;
                        i5Add = 5 * i5Level;

                    }
                    break;
                case "btn50Add":
                    if (iTotal > 5000)
                    {
                        iTotal = iTotal - 5000;

                        i50Level++;
                        i50Add = 50 * i50Level;

                    }
                    break;
                default:
                    break;
            }
        }

    }
}
