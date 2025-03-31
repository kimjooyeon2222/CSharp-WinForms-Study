using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List
{
    public partial class Form1 : Form
    {

        List<string> _strList = new List<string>();
        
        ArrayList _arList = new ArrayList ();



        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pbox_Click(object sender, EventArgs e)
        {
            PictureBox pbox = sender as PictureBox;
            string strSelectText = string.Empty;

            switch (pbox.Name)
            {
                case "pbox1":
                    strSelectText = "cake";
                    break;

                case "pbox2":
                    strSelectText = "burger";
                    break;

                case "pbox3":
                    strSelectText = "pizza";
                    break;

                case "pbox4":
                    strSelectText = "ice";
                    break;
            }

            _strList.Add(strSelectText);
            /*_arList.Add(strSelectText);
            _arList.Add(1);*/

        }

    }
}
