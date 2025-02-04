using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Study
{
    abstract class CBase
    {
        public string strName;
        protected Pen _Pen;
        public Rectangle _rtCircle1; // 바퀴
        public Rectangle _rtSquare1; // 몸통

        public CBase()
        {
            _Pen = new Pen(Color.Aqua);
        }

        //외부에서 호출 가능하도록 (public)
        public abstract void fMove(int iMove);
    

        //내부에서만 움직인다 (protected)
        protected void fCircle1Move(int iMove)
        {
            Point oPoint = _rtCircle1.Location;
            oPoint.X = oPoint.X + iMove;
            _rtCircle1.Location = oPoint;

        }

        //내부에서만 움직인다 (protected)
        protected void fSqaure1Move(int iMove)
        {
            Point oPoint = _rtSquare1.Location;
            oPoint.X = oPoint.X + iMove;
            _rtSquare1.Location = oPoint;

        }

    }
}
