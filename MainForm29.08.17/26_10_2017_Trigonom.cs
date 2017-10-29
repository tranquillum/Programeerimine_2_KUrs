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

        Pen Pliiats1 = new Pen(Color.Gray, 1);
        Pen Pliiats3 = new Pen(Color.Black, 3);
        Pen Pliiats2 = new Pen(Color.Black, 2);

        int GBlaius, GBkorgus;
        Graphics g;
        double xalg, xlopp, yalg, ylopp,dy,dx,xpoint,ypoint;

        private void PA_PictureBox_Click(object sender, EventArgs e)
        {

        }

        int nx, ny;
        public _26_10_2017_Trigonom()
        {
            InitializeComponent();

            Pliiats1.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Pliiats3.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            Pliiats2.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;

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
 
            int x1 = (int)xalg;
            int x2 = (int)xlopp;
            if (x1 > 0) x1 = 0;       
            if (x2 < 0) x2 = 0;

            int y1 = (int)yalg;
            int y2 = (int)ylopp;
            if (y1 > 0) y1 = 0;        
            if (y2 < 0) y2 = 0;

            int nxx = x2 - x1;
            int nyy = y2 - y1;
           
            float dx = (float)GBlaius / nxx;
            float dy = (float)GBkorgus / nyy;
            int nx0 = -x1;
            int ny0 = -y1;

            for (int ix = 0; ix <= nxx; ix++)
            {
                g.DrawLine(Pliiats1, ix * dx, 0, ix * dx, GBkorgus);
                g.DrawLine(Pliiats3, ix * dx, (ny0 * dy) - 15, ix * dx, (ny0 * dy) + 15);              
            }
            for (int ix = 0; ix <= nxx*10; ix++)
            {              
                g.DrawLine(Pliiats2, ix * dx/5, (ny0 * dy) - 6, ix * dx/5, (ny0 * dy) + 6);
            }
            for (int iy = 0; iy <= nyy; iy++)
            {
                g.DrawLine(Pliiats1, 0, iy * dy, GBlaius, iy * dy);
                g.DrawLine(Pliiats3, (nx0 * dx) - 15, iy * dy, (nx0 * dx) + 15, iy * dy);
            }
            for (int iy = 0; iy <= nyy*10; iy++)
            {                
                g.DrawLine(Pliiats3, (nx0 * dx) - 6, iy * dy/5, (nx0 * dx) + 6, iy * dy/5);
            }


            g.DrawLine(Pliiats3, nx0 * dx, 0, nx0 * dx, GBkorgus);
            g.DrawLine(Pliiats3, 0, ny0 * dy, GBlaius, ny0 * dy);


        }
    }
}
