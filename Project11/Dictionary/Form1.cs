using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class Form1 : Form
    {

        enum enBossName
        {
            주연,
            혜원,
            경동,
            민정,

        }

        enum enClassName
        {
            진,
            정국,
            RM,
            지민,
            제이홉,
            뷔,
            슈가,

            은비,
            사쿠라,
            해원,
            예나,
            채연,
            채원,
            민주,
            히토미,
            유리,
            유진,
            원영,
            나코,

        }

 /*       List<string> _strList = new List<string>();

        ArrayList _arList = new ArrayList();*/

        int _iPlayerCount = 0;

      //  Hashtable _ht = new Hashtable();
        Dictionary<string, string> _dic = new Dictionary<string, string>();



        public Form1()
        {
            InitializeComponent();
           /* dgViewList.Columns.Add("dgKey", "Key"); // add Column
            dgViewList.Columns.Add("dgValue", "Value"); // add Column*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pbox_Click(object sender, EventArgs e)
        {
            PictureBox pbox = sender as PictureBox;
            string strSelectText = string.Empty;

            switch (pbox.Name)
            {
                case "pbox1":
                    strSelectText = enBossName.주연.ToString();
                    break;

                case "pbox2":
                    strSelectText = enBossName.혜원.ToString();
                    break;

                case "pbox3":
                    strSelectText = enBossName.경동.ToString();
                    break;

                case "pbox4":
                    strSelectText = enBossName.민정.ToString();
                    break;
            }

            int iTotalCount = Enum.GetValues(typeof(enClassName)).Length;


            if (iTotalCount > _iPlayerCount)
            {
                enClassName enName = (enClassName)_iPlayerCount;
                _dic.Add(enName.ToString(), strSelectText);
                fUIDisplay(iTotalCount, enName.ToString());
                fDataGridViewDisplay();

                _iPlayerCount++;
            }
            else
            {
                lblPlayerName.Text = "투표를 완료했습니다.";
            }

        }

        private void fDataGridViewDisplay()
        {
            /*  dgViewList.Rows.Clear();


              foreach (KeyValuePair<string,string> oitem in _dic)
              {
                  dgViewList.Rows.Add(oitem.Key,oitem.Value);
              }*/

            dgViewList.DataSource = _dic.ToArray();







            foreach (DataGridViewRow oRow in dgViewList.Rows)
            {
                oRow.HeaderCell.Value = oRow.Index.ToString();

            }




            dgViewList.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        private void fUIDisplay(int iTotalCount, string strPlayerName)
        {
            int i주연 = 0;
            int i혜원 = 0;
            int i경동 = 0;
            int i민정 = 0;

            foreach (string oitem in _dic.Values)
            {
                switch (oitem)
                {
                    case "주연":
                        i주연++;
                        break;
                    case "혜원":
                        i혜원++;
                        break;
                    case "경동":
                        i경동++;
                        break;
                    case "민정":
                        i민정++;
                        break;

                }
            }

            lblPick1.Text = i주연.ToString();
            lblPick2.Text = i혜원.ToString();
            lblPick3.Text = i경동.ToString();
            lblPick4.Text = i민정.ToString();



            lblTotalCount.Text = string.Format("{0} / {1}", _iPlayerCount+ 1, iTotalCount);
            lblPlayerName.Text = strPlayerName;


        }
    } 
}