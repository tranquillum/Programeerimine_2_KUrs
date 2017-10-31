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
        Pen Pliiats5 = new Pen(Color.Red, 5);

        int GBlaius, GBkorgus;
        Graphics g;
        double xalg, xlopp, yalg, ylopp,dy,dx,xpoint,ypoint;

        

        float nx, ny;

        private void PA_Clean_Click(object sender, EventArgs e)
        {
            PA_PictureBox.Image = null;
        }

        public _26_10_2017_Trigonom()
        {
            InitializeComponent();

            Pliiats1.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Pliiats3.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            Pliiats2.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            Pliiats5.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;

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

        private void PA_CtgM_Click(object sender, EventArgs e)
        {
            if (PA_CtgM.Text == "+") PA_CtgM.Text = "-"; else PA_CtgM.Text = "+";
        }

        private void PA_TgM_Click(object sender, EventArgs e)
        {
            if (PA_TgM.Text == "+") PA_TgM.Text = "-"; else PA_TgM.Text = "+";
        }

        private void PA_CosM_Click(object sender, EventArgs e)
        {
            if (PA_CosM.Text == "+") PA_CosM.Text = "-"; else PA_CosM.Text = "+";
        }

        private void PA_SinM_Click(object sender, EventArgs e)
        {
            if (PA_SinM.Text == "+") PA_SinM.Text = "-"; else PA_SinM.Text = "+";
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

        private double F1(double x)
        {
            double y = 0;
            double a1 = Convert.ToInt32(PA_SinArv.Text);
            if (PA_SinArv.Text == "-") a1 = -a1;
            y += a1*Math.Sin(x);

            double a2 = Convert.ToInt32(PA_CosArv.Text);
            if (PA_CosArv.Text == "-") a2 = -a2;
            y += a2*Math.Cos(x);

            double a3 = Convert.ToInt32(PA_TgArv.Text);
            if (PA_TgArv.Text == "-") a3 = -a3;
            y += a3*Math.Tan(x);

            //double a4 = Convert.ToInt32(PA_CtgM.Text);
            //if (PA_CtgM.Text == "-") a4 = -a4;
            //y += a4 * (Math.Cos(x) / Math.Sin(x));



            return y;
        }

        private void PA_Graafik_Click(object sender, EventArgs e)
        {


            float nxx = (float)xlopp - (float)xalg;
            float nyy = (float)ylopp - (float)yalg;
           
            float dx = (float)GBlaius / nxx;
            float dy = (float)GBkorgus / nyy;

            int nx0 = GBlaius / 2;
            int ny0 = GBkorgus / 2;




            float x1 =(float) xalg;
            float y1 = (float)F1(x1);
            for (float x2 = (float)xalg; x2 <= xlopp; x2 += 0.1f)
            {
                float y2 = (float)F1(x2);
                g.DrawLine(Pliiats5, (x1 * dx + nx0), (ny0 - y1 * dy), (x2 * dx + nx0), (ny0 - y2 * dy));
                x1 = x2;
                y1 = y2;
            }




        }


    }
}
