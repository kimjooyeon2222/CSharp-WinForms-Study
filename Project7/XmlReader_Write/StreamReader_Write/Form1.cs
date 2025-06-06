﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamReader_Write
{
    public partial class Form1 : Form
    {

        CXMLControl _XML = new CXMLControl();
        Dictionary<string,string> _dData = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tboxConfigData_TextChanged(object sender, EventArgs e)
        {

        }

        private void tboxData_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfigSet_Click(object sender, EventArgs e)
        {
            string strEnter = "\r\n";
            string strText = tboxData.Text;
            bool bChecked = cboxData.Checked;
            int iNumber = (int)numData.Value;

            StringBuilder sb = new StringBuilder();
            sb.Append(strText + strEnter);
            sb.Append(bChecked.ToString() + strEnter);
            sb.Append(iNumber.ToString() + strEnter);

            tboxConfigData.Text = sb.ToString();

            _dData.Clear();
            _dData.Add(CXMLControl._TEXT_DATA, strText);
            _dData.Add(CXMLControl._CBOX_DATA, bChecked.ToString());
            _dData.Add(CXMLControl._NUMBER_DATA, strText);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strFilePath = string.Empty;
            SFDialog.InitialDirectory = Application.StartupPath; // 프로그램 실행 파일 위치
            SFDialog.FileName = "*.xml";
            SFDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";

            if(SFDialog.ShowDialog() == DialogResult.OK)
            {
                strFilePath = SFDialog.FileName;
                /*  StreamWriter swSFDialog = new StreamWriter(strFilePath);
                  swSFDialog.WriteLine(tboxConfigData.Text);
                  swSFDialog.Close();*/

                // File.WriteAllText(strFilePath, tboxConfigData.Text);

                _XML.fXML_Writer(strFilePath, _dData);

            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string strText = tboxData.Text;
            string strFilePath = string.Empty;
            string strEnter = "\r\n";

            OFDialog.InitialDirectory = Application.StartupPath; // 프로그램 실행 파일 위치
            OFDialog.FileName = "*.txt";
            OFDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            StringBuilder sb = new StringBuilder();
            if(OFDialog.ShowDialog() == DialogResult.OK)
            {
                strFilePath = OFDialog.FileName;
             /*   StreamReader srOFDialog = new StreamReader(strFilePath);

                while (srOFDialog.EndOfStream == false)
                {
                   sb.Append(srOFDialog.ReadLine() + strEnter);
                }*/

                sb.Append(File.ReadAllText(strFilePath));
                tboxConfigData.Text = sb.ToString();


                tboxConfigData.Text = sb.ToString();
                _dData.Clear();
                _dData = _XML.fXML_Reader(strFilePath);


            }

        }

        private void btnConfigRead_Click(object sender, EventArgs e)
        {
            /*string[] strConfig = tboxConfigData.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            tboxData.Text = strConfig[0];
            cboxData.Checked = bool.Parse(strConfig[1]);
            numData.Value = int.Parse(strConfig[2]);
*/

            tboxData.Text = _dData[CXMLControl._TEXT_DATA];
            cboxData.Checked = bool.Parse(_dData[CXMLControl._CBOX_DATA]);
            numData.Value = int.Parse(_dData[CXMLControl._NUMBER_DATA]);
        }

        private void numData_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
