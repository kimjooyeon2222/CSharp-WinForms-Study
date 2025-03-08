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
        CCycle _cC;
        CCar _cCar;
        CBike _cBike;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            _cOC = new COneCycle("외발 자전거");
            _cC = new CCycle("자전거");
            _cCar = new CCar("자동차");
            _cBike = new CBike("오토바이");

        }

        private void Form1_KeyDown1(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Q)
            {
                if (lblName.Text == _cOC.strName)
                {
                    fClearPanel();
                    _cOC.fMove(-5);
                    fOneCycleDraw();

                }
                else if (lblName.Text == _cC.strName)
                {
                    fClearPanel();
                    _cC.fMove(-5);
                    fCycleDraw();

                }
                else if (lblName.Text == _cCar.strName)
                {
                    fClearPanel();
                    _cCar.fMove(-5);
                    fCarDraw();

                }
                else if(lblName.Text == _cBike.strName)
                {
                    fClearPanel();
                    _cBike.fMove(-5);
                    fBikeDraw();
                }
            }
            else if (e.KeyCode == Keys.E)
            {
                if (lblName.Text == _cOC.strName)
                {
                    fClearPanel();
                    _cOC.fMove(5);
                    fOneCycleDraw();

                }
                else if (lblName.Text == _cC.strName)
                {
                    fClearPanel();
                    _cC.fMove(5);
                    fCycleDraw();

                }
                else if (lblName.Text == _cCar.strName)
                {
                    fClearPanel();
                    _cCar.fMove(5);
                    fCarDraw();

                }
                else if (lblName.Text == _cBike.strName)
                {
                    fClearPanel();
                    _cBike.fMove(5);
                    fBikeDraw();
                }
            }

        
    }

        private void btnOneCycle_Click(object sender, EventArgs e)
        {
            fClearPanel();
            fOneCycleDraw();
        }
        private void btnCycle_Click(object sender, EventArgs e)
        {
            fClearPanel();
            fCycleDraw();
        }

    
    private void btnCar_Click(object sender, EventArgs e)
    {
        fClearPanel();
        fCarDraw();
    }
    private void pMain_Paint(object sender, PaintEventArgs e)
        {

        }

        //OneCycle에 대한 위치 그림을 그려준다.
        private void fOneCycleDraw()
        {
            lblName.Text = _cOC.strName;
            Graphics g = pMain.CreateGraphics();
            Pen p = _cOC.fPenInfo();
            g.DrawRectangle(p, _cOC._rtSquare1);
            g.DrawEllipse(p, _cOC._rtCircle1);

        }

        private void fCycleDraw()
        {
            lblName.Text = _cC.strName;
            Graphics g = pMain.CreateGraphics();
            Pen p = _cC.fPenInfo();
            g.DrawRectangle(p, _cC._rtSquare1);
            g.DrawEllipse(p, _cC._rtCircle1);
            g.DrawEllipse(p, _cC._rtCircle2);

        }
    private void fCarDraw()
    {
        lblName.Text = _cCar.strName;
        Graphics g = pMain.CreateGraphics();
        Pen p = _cCar.fPenInfo();
        g.DrawRectangle(p, _cCar._rtSquare1);
        g.DrawRectangle(p, _cCar._rtSquare2);
        g.DrawEllipse(p, _cCar._rtCircle1);
        g.DrawEllipse(p, _cCar._rtCircle2);

    }

    private void fBikeDraw()
    {
        lblName.Text = _cBike.strName;
        Graphics g = pMain.CreateGraphics();
        Pen p = _cBike.fPenInfo();
        g.DrawRectangle(p, _cBike._rtSquare1);
        g.DrawEllipse(p, _cBike._rtCircle1);
        g.DrawEllipse(p, _cBike._rtCircle2);

    }

    private void fClearPanel()
        {
            pMain.Invalidate();
            Refresh();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (lblName.Text == _cOC.strName)
            {
                fClearPanel();
                _cOC.fMove(-5);
                fOneCycleDraw();

            }
            else if (lblName.Text == _cC.strName)
            {
                fClearPanel();
                _cC.fMove(-5);
                fCycleDraw();

            }
            else if (lblName.Text == _cCar.strName)
            {
                fClearPanel();
                _cCar.fMove(-5);
                fCarDraw();

            }
            else if (lblName.Text == _cBike.strName)
            {
                fClearPanel();
                _cBike.fMove(-5);
                fBikeDraw();
            }

        }

        private void btnRight_Click(object sender, EventArgs e)
        {

            if (lblName.Text == _cOC.strName)
            {
                fClearPanel();
                _cOC.fMove(5);
                fOneCycleDraw();

            }
            else if (lblName.Text == _cC.strName)
            {
                fClearPanel();
                _cC.fMove(5);
                fCycleDraw();

            }
           else if (lblName.Text == _cCar.strName)
            {
                fClearPanel();
                _cCar.fMove(5);
                fCarDraw();

            }
            else if (lblName.Text == _cBike.strName)
            {
                fClearPanel();
                _cBike.fMove(5);
                fBikeDraw();
            }
        }

        private void btnBike_Click(object sender, EventArgs e)
        {
            fClearPanel();
            fBikeDraw();
        }
    }
}
