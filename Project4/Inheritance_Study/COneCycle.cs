using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Inheritance_Study
{
    internal class COneCycle : CBase
    {

        public Rectangle _rtCircle1; // 바퀴
        public Rectangle _rtSquare1; // 몸통
      public COneCycle(string sName)
        {
            strName = sName;
            _Pen = new Pen(Color.WhiteSmoke,3);
            _rtCircle1 = new Rectangle(45, 105, 20, 30);
            _rtSquare1 = new Rectangle(25, 25, 60, 80);

        }


        public Pen fPenInfo()
        {
            return _Pen;
        }
    }
}
