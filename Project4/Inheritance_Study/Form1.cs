using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance_Study
{
    public partial class Form1 : Form
    {

        COneCycle _cOC;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            _cOC = new COneCycle("외발 자전거");
        }

        private void btnOneCycle_Click(object sender, EventArgs e)
        {
            OneCycleDraw();
        }

        private void pMain_Paint(object sender, PaintEventArgs e)
        {

        }

        //OneCycle에 대한 위치 그림을 그려준다.
        private void OneCycleDraw()
        {
            lblName.Text = _cOC.strName;
            Graphics g = pMain.CreateGraphics();
            Pen p = _cOC.fPenInfo();
            g.DrawRectangle(p, _cOC._rtSquare1);
            g.DrawEllipse(p, _cOC._rtCircle1);

        }

    }
}
