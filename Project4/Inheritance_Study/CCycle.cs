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
        public Rectangle _rtCircle1; // 바퀴
        public Rectangle _rtCircle2; // 바퀴
        public Rectangle _rtSquare1; // 몸통
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
    }
}
