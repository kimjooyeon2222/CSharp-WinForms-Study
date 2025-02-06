using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Study
{
    partial class cData
    {
        private string _strItem = string.Empty;
        private double _dTotalPrice = 0.0;
        public double DTotalPrice { 
            get => _dTotalPrice;
            set {
                if (value != 0)
                {
                    _dTotalPrice += value;
                }else
                {
                    _dTotalPrice = 0.0;
                }
            }
        }


        public string StrItem
        {
            get { return _strItem; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    _strErrorName = "물건이 선택되지 않았습니다.";
                }
                else
                {
                    _strItem = value;
                }

            }
        }

        public int IRate {

            get { return _iRate; }
            set { 
                
                if(value > 20)
                {
                    _strErrorName = "사장님만 가능한 할인입니다.";
                }
                else
                {
                    _iRate = value;
                }

            }
        
        }
        public int ICount
        {
            set
            {
                if (value > 5)
                {
                    _strErrorName = "개별 물품은 5개이상 살 수 없습니다.";
                }
                else if(value ==0)
                {
                    _strErrorName = "물품의 개수가 0개입니다.";
                }
                else
                {
                    _iCount = value;

                }
            }
        }

        public string StrErrorName {
            get => _strErrorName; 
            //set => _strErrorName = value;
                                                          
        }

        private int _iRate = 0;
        private int _iCount = 0;

        private string _strErrorName = string.Empty;


    }

    partial class cData
    {
        public double ItemPrice()
        {
            double dPrice = 0;
            int iItemPrice = 0;

            if (String.IsNullOrEmpty(_strErrorName)) //error가 없으므로 정상 값들을 받았다.
            {
                iItemPrice = (int)Enum.Parse(typeof(EnumItem), _strItem);
                dPrice = iItemPrice - Math.Round((double)iItemPrice * (double)_iRate / 100, 2);
            }

            return dPrice * _iCount;
        }
    }

    partial class cData
    {
        public string fResult(double dPrice)
        {
            if (_iRate == 0)
            {
                return string.Format("{0} X {1}: {2}원", _strItem, _iCount, dPrice);

            }
            else
            {
                return string.Format("{0} X {1}: {2}원 (할인율: {3}%)", _strItem, _iCount, dPrice, _iRate);
            }
        }

        public void fDataResult()
        {
            _strErrorName = string.Empty;
            _strItem = string.Empty;
            _iRate = 0;
            _iCount = 0;
        }
    }

}
