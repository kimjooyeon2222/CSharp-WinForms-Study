using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace List
{
    public partial class Form1 : Form
    {
        List<string> _strList = new List<string>();
        ArrayList _arList = new ArrayList(); // 아직 사용 X

        public Form1()
        {
            InitializeComponent();
            if (dgViewList.Columns.Count == 0)
                dgViewList.Columns.Add("dgValue", "Value"); // 중복 방지
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e) { }

        private void Form1_Load(object sender, EventArgs e) { }

        private void pbox_Click(object sender, EventArgs e)
        {
            PictureBox pbox = sender as PictureBox;
            if (pbox == null) return;

            string strSelectText = string.Empty;

            switch (pbox.Name)
            {
                case "pbox1": strSelectText = "cake"; break;
                case "pbox2": strSelectText = "burger"; break;
                case "pbox3": strSelectText = "pizza"; break;
                case "pbox4": strSelectText = "ice"; break;
                default: return; // 예상 외 PictureBox는 무시
            }

            _strList.Add(strSelectText);
            fUIDisplay();
            fDataGridViewDisplay();
        }

        private void fDataGridViewDisplay()
        {
            dgViewList.Rows.Clear();

            foreach (string item in _strList)
            {
                dgViewList.Rows.Add(item);
            }

            foreach (DataGridViewRow row in dgViewList.Rows)
            {
                row.HeaderCell.Value = row.Index.ToString();
            }

            dgViewList.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        private void fUIDisplay()
        {
            int iCake = 0, iBurger = 0, iPizza = 0, iIce = 0;

            foreach (string item in _strList)
            {
                switch (item)
                {
                    case "cake": iCake++; break;
                    case "burger": iBurger++; break;
                    case "pizza": iPizza++; break;
                    case "ice": iIce++; break;
                }
            }

            lblPick1.Text = iCake.ToString();
            lblPick2.Text = iBurger.ToString();
            lblPick3.Text = iPizza.ToString();
            lblPick4.Text = iIce.ToString();
            lblTotalCount.Text = _strList.Count.ToString();
        }
    }
}
