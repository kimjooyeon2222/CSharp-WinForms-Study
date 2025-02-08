using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Partial_Study
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        cData _Data = new cData();

        private void Form1_Load(object sender, EventArgs e)
        {
            cboxRate.Text = "0";
            EnumItem[] ei = (EnumItem[])Enum.GetValues(typeof(EnumItem));

            foreach (var item in ei)
            {
                cboxItem.Items.Add(item.ToString());
            }

            foreach (var item in (EnumRate[])Enum.GetValues(typeof(EnumRate)))
            {
                cboxRate.Items.Add(item.ToString());
            }

        }

        private void lboxItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _Data.fDataResult();
            _Data.StrItem = cboxItem.Text;

            if (!String.IsNullOrEmpty(_Data.StrErrorName))
            {
                tboxErrorMsg.Text = _Data.StrErrorName;
                return;
            }

            _Data.IRate = (int)Enum.Parse(typeof(EnumRate), cboxRate.Text);

        
            _Data.ICount = (int)numCout.Value;

            if (!String.IsNullOrEmpty(_Data.StrErrorName))
            {
                tboxErrorMsg.Text = _Data.StrErrorName;
                return;
            }

            double dPrice = _Data.ItemPrice();
            lboxItem.Items.Add(_Data.fResult(dPrice));

            _Data.DTotalPrice = dPrice;
            tboxResult.Text ="가격은 "+ _Data.DTotalPrice.ToString() + "원입니다.";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _Data.fDataResult();
            _Data.DTotalPrice = 0;
            tboxResult.Text="";
            lboxItem.Items.Clear();
            tboxErrorMsg.Text="";
        }

        private void cboxItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
