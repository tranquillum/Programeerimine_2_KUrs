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
        double xalg, xlopp, yalg, ylopp,dy,dx,xpoint,ypoint;
        int nx, ny;
        public _26_10_2017_Trigonom()
        {
            InitializeComponent();
            GBlaius = PA_PictureBox.Width - 1;
            GBkorgus = PA_PictureBox.Height - 1;
            g = Graphics.FromHwnd(PA_PictureBox.Handle);
            xalg = -2 * Math.PI;
            xlopp = 2 * Math.PI;
            dx = Math.PI/2;
            nx = 9;
            yalg = -3 ;
            ylopp = 3 ;
            dy = 1;
            ny = 10;
            PA_PictureBox.Height =(int)((ylopp-yalg) /(xlopp - xalg)*PA_PictureBox.Width);
            xpoint = PA_PictureBox.Width / (xlopp - xalg);
            ypoint = PA_PictureBox.Height / (ylopp - yalg);
        }

        private void _26_10_2017_Trigonom_Load(object sender, EventArgs e)
        {

        }

        private void PA_Teljed_Click(object sender, EventArgs e)
        {
            int countx = 0;
            int county = 0;
            float dx = (float)PA_PictureBox.Width / 6;
            float dy = (float)PA_PictureBox.Height / 4;

           



            Pliiats.Width = 3;
            Pliiats.Color = Color.Black;
            Pliiats.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            float nx0 = GBlaius / 2;
            float ny0 = GBkorgus / 2;
            g.DrawLine(Pliiats, nx0, 0, nx0, GBkorgus);
            g.DrawLine(Pliiats, 0, ny0, GBlaius, ny0);



            Pliiats.Width = 1;
            Pliiats.Color = Color.Black;
            Pliiats.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            for (float ix = 0; ix <= dx; ix++)
            {
                for (float i = 0; i <= dx ;i +=dx/4)
                {
                    g.DrawLine(Pliiats, nx0 - 3, (ny0 - iy) * dy / 5, nx0 + 3, (ny0 - iy) * dy / 5);
                }


            }
            for (int iy =-3 ; iy <= 3; iy++)
            {
                if (county <= 3)
                {
                    g.DrawLine(Pliiats, nx0 - 3, (ny0-iy) * dy/5,nx0 + 3, (ny0 - iy) * dy/5);

                    county++;
                }
                else
                {
                    county = 0;
                    g.DrawLine(Pliiats, nx0 - 6, (ny0 - iy) * dy/5, nx0 + 6, (ny0 - iy) * dy/5);
                }
            }
            //for (int ix = 0; ix <= dx; ix++)
            //    g.DrawLine(Pliiats, ix * dx, 0, ix * dx, GBkorgus);
            //for (int iy = 0; iy <= dy; iy++)
            //    g.DrawLine(Pliiats, 0, iy * dy, GBlaius, iy * dy);


        }
    }
}
