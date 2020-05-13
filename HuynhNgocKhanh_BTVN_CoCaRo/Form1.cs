using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuynhNgocKhanh_BTVN_CoCaRo
{
    public partial class Form1 : Form
    {
        //Variable
        private Button[,] banCo;
        private int size;

        public Form1()
        {
            InitializeComponent();
            initMyComponent();
        }

        private void initMyComponent()
        {
            size = 10;
            banCo = new Button[size,size];

            //Tai cac o len ban co
            taiOLenBanCo();
        }

        private void taiOLenBanCo()
        {
            int width = 40;
            Button btn;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    btn = taoO(j * (width + 3), i * (width + 3));
                    banCo[i, j] = btn;
                    pnBanCo.Controls.Add(btn);
                }
            }
        }

        //Tao mot o tren ban co
        private Button taoO(int i, int j)
        {
            Button btn = new Button();
            btn.Width = btn.Height = 40;
            btn.Location = new Point(i, j);
            return btn;
        }
    }
}