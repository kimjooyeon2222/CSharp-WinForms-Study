using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker_Game
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> _dData = new Dictionary<string, string>();
        CXMLControl _xml = new CXMLControl();

        string strPath = Application.StartupPath + "\\Save.txt";

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
            this.FormClosing += Form1_FormClosing;  // 종료 이벤트 연결
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(strPath))
            {
                // File이 있을 경우 File Loading
                _dData = _xml.fXML_Reader(strPath);

                iTick = double.Parse(_dData[CXMLControl._TICK]);
                iTotal = double.Parse(_dData[CXMLControl._TOTAL]);

                i1Level = int.Parse(_dData[CXMLControl._LEVEL_1]);
                i5Level = int.Parse(_dData[CXMLControl._LEVEL_5]);
                i50Level = int.Parse(_dData[CXMLControl._LEVEL_50]);
            }

            Timer oTimer = new Timer();
            oTimer.Enabled = true;
            oTimer.Interval = 1000;
            oTimer.Tick += OTimer_Tick;
            oTimer.Start();
        }

        // 종료 직전 호출되는 이벤트
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _dData.Clear();
            _dData.Add(CXMLControl._TICK, iTick.ToString());
            _dData.Add(CXMLControl._TOTAL, iTotal.ToString());
            _dData.Add(CXMLControl._LEVEL_1, i1Level.ToString());
            _dData.Add(CXMLControl._LEVEL_5, i5Level.ToString());
            _dData.Add(CXMLControl._LEVEL_50, i50Level.ToString());

            MessageBox.Show("Save path: " + strPath);

            try
            {
                _xml.fXML_Writer(strPath, _dData);
                MessageBox.Show("저장 완료!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("저장 실패: " + ex.Message);
            }
        }

        // 타이머에서 호출할 Event (Interval 간격 기준)
        private void OTimer_Tick(object sender, EventArgs e)
        {
            iTick = i1Add + i5Add + i50Add;
            iTotal += iTick;

            lblTickPoint.Text = string.Format("{0} (1:{1}), (5:{2}), (50:{3})",
                iTick.ToString(), i1Level.ToString(), i5Level.ToString(), i50Level.ToString());
            lblTotal.Text = iTotal.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Button obtn = sender as Button;

            switch (obtn.Name)
            {
                case "btn1Add":
                    if (iTotal > 100)
                    {
                        iTotal -= 100;
                        i1Level++;
                        i1Add = 1 * i1Level;
                    }
                    break;

                case "btn5Add":
                    if (iTotal > 500)
                    {
                        iTotal -= 500;
                        i5Level++;
                        i5Add = 5 * i5Level;
                    }
                    break;

                case "btn50Add":
                    if (iTotal > 5000)
                    {
                        iTotal -= 5000;
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
