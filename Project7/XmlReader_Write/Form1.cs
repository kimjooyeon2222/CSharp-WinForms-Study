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

namespace StreamReader_Write
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

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strFilePath = string.Empty;
            SFDialog.InitialDirectory = Application.StartupPath; // 프로그램 실행 파일 위치
            SFDialog.FileName = "*.txt";
            SFDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if(SFDialog.ShowDialog() == DialogResult.OK)
            {
                strFilePath = SFDialog.FileName;
              /*  StreamWriter swSFDialog = new StreamWriter(strFilePath);
                swSFDialog.WriteLine(tboxConfigData.Text);
                swSFDialog.Close();*/

                File.WriteAllText(strFilePath, tboxConfigData.Text);

            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
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
            }

        }

        private void btnConfigRead_Click(object sender, EventArgs e)
        {
            string[] strConfig = tboxConfigData.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            tboxData.Text = strConfig[0];
            cboxData.Checked = bool.Parse(strConfig[1]);
            numData.Value = int.Parse(strConfig[2]);

        }

        private void numData_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
