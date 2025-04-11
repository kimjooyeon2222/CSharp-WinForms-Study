using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTable_study
{
    public partial class Form1 : Form
    {
        DataSet ds = new DataSet(); // 학급들에 대한 정보를 가지고 있을 때 DataSet
        

        
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           


        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            bool bCheckisTable = false;

            if (ds.Tables.Contains(cboxRegClass.Text))
            {
                bCheckisTable = true;
            }



            DataTable dt = null;

            if (!bCheckisTable)
            {
                dt = new DataTable(cboxRegClass.Text);

                DataColumn colName = new DataColumn("NAME", typeof(string));
                DataColumn colSex = new DataColumn("SEX", typeof(string));
                DataColumn colRef = new DataColumn("REF", typeof(string));

                dt.Columns.Add(colName);
                dt.Columns.Add(colSex);
                dt.Columns.Add(colRef);
            }
            else
            {
                dt = ds.Tables[cboxRegClass.Text];
            }



            //Row 자료를 등록
            DataRow row = dt.NewRow();

            row["NAME"] = tboxRegName.Text;

            if (rdoRegSexMale.Checked)
            {
                row["SEX"] = "남자";
            }
            else if (rdoRegSexFemale.Checked)
            {
                row["SEX"] = "여자";
            }

            row["SEX"] = tboxRegName.Text;

            row["NAME"] = tboxRegName.Text;

            row["REF"] = tboxRegRef.Text;


            // 생성한 Row를 Table에 등록

            /* dt.Rows.Add(row);
             if (bCheckisTable)
             {
                 ds.Tables.Remove(cboxRegClass.Text);
                 ds.Tables.Add(dt);
             }
             ds.Tables.Add(dt);*/

            if (bCheckisTable)
            {
                ds.Tables[cboxRegClass.Text].Rows.Add(row);
            }
            else
            {
                dt.Rows.Add(row);
                ds.Tables.Add(dt);

            }

            cboxViewClass_SelectedIndexChanged(this, null);

        }

        private void btnViewDataDel_Click(object sender, EventArgs e)
        {

        }

        private void cboxViewClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgViewInfo.DataSource = ds.Tables[cboxViewClass.Text];


            //DatagridView Cell 정렬 및 Number를 적용
            foreach (DataGridViewRow oRow in dgViewInfo.Rows)
            {
                oRow.HeaderCell.Value = oRow.Index.ToString();
            }
            dgViewInfo.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

        }


        private void cboxRegClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
