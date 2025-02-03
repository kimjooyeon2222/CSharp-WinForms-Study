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
            public int ColorSum()
            {
                return iRed + iOrange + iYellow;
            }

            //결과를 String 형태로 변환 (화면에 결과를 보여주기 위해 사용)
            public string ResultText()
            {
                return string.Format("{0}회) 빨강:{1}, 주황: {2}, 노랑: {3} => 합계는 {4}입니다.", iCount, iRed, iOrange, iYellow, iColorSum);
            }
        }

        structPlayer _srtPlayer1; //1번 플레이어
        structPlayer _srtPlayer2; //2번 플레이어

        Random _rd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void pboxRed_Click(object sender, EventArgs e)
        {

            
            int num = _rd.Next(1,31);
            if (rdoPlayer1.Checked)
            {
                _srtPlayer1.iYellow = 0;
                _srtPlayer1.iOrange = 0;
                _srtPlayer1.iRed = num;
            }
            else
            {
                _srtPlayer2.iYellow = 0;
                _srtPlayer2.iOrange = 0;
                _srtPlayer2.iRed = num;
            }
            Result();
            leader_Board_Result();

        }

        private void pboxYellow_Click(object sender, EventArgs e)
        {
            int num = _rd.Next(1, 31);
            if (rdoPlayer1.Checked)
            {
                _srtPlayer1.iYellow = num;
                _srtPlayer1.iOrange = 0;
                _srtPlayer1.iRed = 0;
            }
            else
            {
                _srtPlayer2.iYellow = num;
                _srtPlayer2.iOrange = 0;
                _srtPlayer2.iRed = 0;
            }
            Result();
            leader_Board_Result();
        }

        private void pboxOrange_Click(object sender, EventArgs e)
        {
            int num = _rd.Next(1, 31);
            if (rdoPlayer1.Checked)
            {
                _srtPlayer1.iYellow = 0;
                _srtPlayer1.iOrange = num;
                _srtPlayer1.iRed = 0;
            }
            else
            {
                _srtPlayer2.iYellow = 0;
                _srtPlayer2.iOrange = num;
                _srtPlayer2.iRed = 0;
            }
            Result();
            leader_Board_Result();
        }

        private void pboxNone_Click(object sender, EventArgs e)
        {

         //순서 바꿀 수 있다.

            iCheckedChange();

        }

        private void iCheckedChange()
        {
            if (rdoPlayer1.Checked)
            {
                rdoPlayer2.Checked = true;
            }
            else
            {
                rdoPlayer1.Checked = true;
            }
        }

        private void rdoPlayer2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Result()
        {
            string strResult = string.Empty;
           
            if (rdoPlayer1.Checked)
            {
                _srtPlayer1.iCount++;
                _srtPlayer1.iColorSum += (_srtPlayer1.iRed + _srtPlayer1.iOrange + _srtPlayer1.iYellow);  
                strResult = _srtPlayer1.ResultText();
                lboxResult1.Items.Add(strResult);
            }
            else
            {
                _srtPlayer2.iCount++;
                _srtPlayer2.iColorSum += (_srtPlayer2.iRed + _srtPlayer2.iOrange + _srtPlayer2.iYellow);  
                strResult = _srtPlayer2.ResultText();
                lboxResult2.Items.Add(strResult);

            }
            iCheckedChange();

            if(_srtPlayer1.iCount>=5 && _srtPlayer2.iCount >= 5)
            {
                if(_srtPlayer1.iColorSum > _srtPlayer2.iColorSum)
                {
                    MessageBox.Show("Player1이 이겼습니다!");
                    Application.Exit();

                }
                else if(_srtPlayer1.iColorSum < _srtPlayer2.iColorSum)
                {
                    MessageBox.Show("Player2가 이겼습니다!");
                    Application.Exit();

                }
                else {
                    MessageBox.Show("비겼습니다!");
                    Application.Exit();

                }
            }
        }

        private void leader_Board_Result()
        {
            string str = string.Empty;

            if (_srtPlayer1.iColorSum > _srtPlayer2.iColorSum)
            {
                str = string.Format("합계는 Player1이 {0}만큼 Player2보다 큽니다.", Math.Abs(_srtPlayer1.iColorSum - _srtPlayer2.iColorSum));

            }
            else if (_srtPlayer1.iColorSum < _srtPlayer2.iColorSum)
            {
                str = string.Format("합계는 Player2이 {0}만큼 Player1보다 큽니다.", Math.Abs(_srtPlayer2.iColorSum - _srtPlayer1.iColorSum));

            }
            else
            {
                str = "합계는 Player1과 Player2가 같습니다.";

            }

            leaderBoard.Items.Add(str);
        }

        private void leaderBoard_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void lboxResult1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }
    }
}
