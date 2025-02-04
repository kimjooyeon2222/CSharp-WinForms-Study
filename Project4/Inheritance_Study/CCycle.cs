using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Study
{
    internal class CCycle : CBase
    {
        public Rectangle _rtCircle2; // 바퀴
        public CCycle(string sName)
        {
            strName = sName;
            _Pen = new Pen(Color.Black, 3);
            _rtCircle1 = new Rectangle(30, 105, 20, 30);
            _rtCircle2 = new Rectangle(60, 105, 20, 30);
            _rtSquare1 = new Rectangle(25, 25, 60, 80);

        }


        public Pen fPenInfo()
        {
            return _Pen;
        }

        //외부에서 호출 가능하도록 (public)
        public override void fMove(int iMove)
        {
            fCircle1Move(iMove);
            fSqaure1Move(iMove);
            fCircle2Move(iMove);
        }


        //내부에서만 움직인다 (protected)
        protected void fCircle2Move(int iMove)
        {
            Point oPoint = _rtCircle2.Location;
            oPoint.X = oPoint.X + iMove;
            _rtCircle2.Location = oPoint;

        }


   
    }
}
