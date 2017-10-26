using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm29._08._17
{
    public partial class _26_10_2017_Trigonom : Form
    {

        Pen Pliiats = new Pen(Color.Black, 2);
        int GBlaius, GBkorgus;
        Graphics g;
        double xalg, xlopp, yalg, ylopp;
        public _26_10_2017_Trigonom()
        {
            InitializeComponent();
            GBlaius = PA_PictureBox.Width - 1;
            GBkorgus = PA_PictureBox.Height - 1;
            g = Graphics.FromHwnd(PA_PictureBox.Handle);
            xalg = -2 * Math.PI;
            xlopp = 2 * Math.PI;
            yalg = -3 ;
            ylopp = 3 ;
            PA_PictureBox.Height =(int)((ylopp-yalg) /(xlopp - xalg)*PA_PictureBox.Width);
        }

        private void _26_10_2017_Trigonom_Load(object sender, EventArgs e)
        {

        }

        private void PA_Teljed_Click(object sender, EventArgs e)
        {
            int countx = 0;
            int county = 0;
            float dx = (float)PA_PictureBox.Width / 10;
            float dy = (float)PA_PictureBox.Height / 8;

            for (int ix = 0; ix <= dx; ix++)
            {
                if (countx <= 4)
                {

                    g.DrawLine(Pliiats, ix * dx, (GBkorgus / 2) + 3, ix * dx, (GBkorgus / 2) - 3);
                    countx++;
                }
                else
                {
                    countx = 0;
                    g.DrawLine(Pliiats, ix * dx, (GBkorgus / 2) + 6, ix * dx, (GBkorgus / 2) - 6);
                }
            }
            for (int iy = 0; iy <= dy; iy++)
            {
                if (county <= 4)
                {
                    g.DrawLine(Pliiats, (GBlaius / 2) - 3, iy * dy, (GBlaius / 2) + 3, iy * dy);

                    county++;
                }
                else
                {
                    county = 0;
                    g.DrawLine(Pliiats, (GBlaius / 2) - 6, iy * dy, (GBlaius / 2) + 6, iy * dy);
                }
            }
            



            Pliiats.Width = 3;
            Pliiats.Color = Color.Black;
            Pliiats.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            int nx0 = GBlaius / 2;
            int ny0 = GBkorgus / 2;
            g.DrawLine(Pliiats, nx0, 0, nx0, GBkorgus);
            g.DrawLine(Pliiats, 0, ny0, GBlaius, ny0);




        }
    }
}
