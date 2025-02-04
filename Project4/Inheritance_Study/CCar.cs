using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Study
{
    internal class CCar : CCycle
    {
        
        public Rectangle _rtSquare2; // 몸통

        public CCar(string sName) : base(sName)
        {
            strName = sName;
            _Pen = new Pen(Color.Blue, 3);
            _rtCircle1 = new Rectangle(30, 105, 20, 30);
            _rtCircle2 = new Rectangle(60, 105, 20, 30);
            _rtSquare1 = new Rectangle(25, 65, 60, 40); //아랫몸통
            _rtSquare2 = new Rectangle(40, 35, 30, 30); //윗몸통

        }

        //외부에서 호출 가능하도록 (public)
        public override void fMove(int iMove)
        {
            fCircle1Move(iMove);
            fSqaure1Move(iMove);
            fCircle2Move(iMove);
            fSqaure2Move(iMove);

        }

        //내부에서만 움직인다 (protected)
        protected void fSqaure2Move(int iMove)
        {
            Point oPoint = _rtSquare2.Location;
            oPoint.X = oPoint.X + iMove;
            _rtSquare2.Location = oPoint;

        }

    }
}
