using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sturct_Study
{
    public partial class Form1 : Form
    {

        struct structPlayer
        {
            public int iCount;//player가 몇 회 진행 중인지
            public int iRed;// red에 대한 값
            public int iOrange;// orange에 대한 값
            public int iYellow;// yellow에 대한 값

            public int iColorSum; // sum of red, orange, yellow

            //값을 더해서 반환
            public int ColorSum(int iRed, int iOrange, int iYellow)
            {
                return iRed + iOrange + iYellow;
            }

            public string ResultText()
            {
                return string.Format("{0}회) 빨강:{1}, 주황: {2}, 노랑: {3} => 합계는 {4}입니다.", iCount, iRed, iOrange, iYellow, iColorSum);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void pboxRed_Click(object sender, EventArgs e)
        {

        }

        private void pboxYellow_Click(object sender, EventArgs e)
        {

        }
    }
}
