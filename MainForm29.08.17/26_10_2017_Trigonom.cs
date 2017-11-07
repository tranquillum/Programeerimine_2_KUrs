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
        Pen Pliiats2_2 = new Pen(Color.Blue, 2);
        Pen Pliiats2 = new Pen(Color.Black, 2);
        Pen Pliiats5 = new Pen(Color.Red, 5);

        int GBlaius, GBkorgus;
        Graphics g;
        double xalg, xlopp, yalg, ylopp,dy,dx,xpoint,ypoint;
        Bitmap bmp;
        

        float nx, ny;

        private void PA_Clean_Click(object sender, EventArgs e)
        {            
            PA_PictureBox.Image = null;
            bmp = null;
            PA_PictureBox.Image = bmp;
            bmp = new Bitmap(PA_PictureBox.Width, PA_PictureBox.Height);
            g = Graphics.FromImage(bmp);
        }

        public _26_10_2017_Trigonom()
        {
            InitializeComponent();

            Pliiats1.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Pliiats3.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            Pliiats2.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            Pliiats2_2.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
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
            bmp = new Bitmap(PA_PictureBox.Width, PA_PictureBox.Height);
            g = Graphics.FromImage(bmp);
            xpoint = PA_PictureBox.Width / (xlopp - xalg);
            ypoint = PA_PictureBox.Height / (ylopp - yalg);
        }

        private void PA_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfdlg = new SaveFileDialog();
            sfdlg.Title = "Save Dialog";
            sfdlg.Filter = "Bitmap Image (*.bmp)|*.bmp|All files(*.*)|*.*";
            sfdlg.ShowDialog();
            bmp.Save(sfdlg.FileName);
            MessageBox.Show("Saved Successfully...");


        }

        private void PA_Teljed2_Click(object sender, EventArgs e)
        {
            Pliiats1.Color = Color.Black;
            Pliiats1.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            Pliiats1.Width = 4;
            int x0 = (int)(-xalg * xpoint);
            int y0 = (int)(ylopp * ypoint);
            g.DrawLine(Pliiats1, 0, y0, PA_PictureBox.Width, y0);
            g.DrawLine(Pliiats1, x0, 0, x0, PA_PictureBox.Height);
            Pliiats1.Width = 3;
            for (double x = 0; x < PA_PictureBox.Width; x += dx)
                g.DrawLine(Pliiats1, (int)(x * xpoint), y0 - 10, (int)(x * xpoint), y0 + 10);
            for (double y = 0; y < PA_PictureBox.Height; y += dy)
                g.DrawLine(Pliiats1, x0 - 10, (int)(y * ypoint), x0 + 10, (int)(y * ypoint));
            Pliiats1.Width = 2;
            for (double x = 0; x < PA_PictureBox.Width; x += (dx / nx))
                g.DrawLine(Pliiats1, (int)(x * xpoint), y0 - 5, (int)(x * xpoint), y0 + 5);
            for (double y = 0; y < PA_PictureBox.Height; y += (dy / ny))
                g.DrawLine(Pliiats1, x0 - 5, (int)(y * ypoint), x0 + 5, (int)(y * ypoint));

            Pliiats1.Color = Color.Gray;
            Pliiats1.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Pliiats1.Width = 1;
            for (double x = 0; x < PA_PictureBox.Width; x += dx)
                g.DrawLine(Pliiats1, (int)(x * xpoint), 0, (int)(x * xpoint),PA_PictureBox.Height);
            for (double y = 0; y < PA_PictureBox.Height; y += dy)
                g.DrawLine(Pliiats1, 0,(int)(y*ypoint),PA_PictureBox.Width, (int)(y * ypoint));
            PA_PictureBox.Image = bmp;
        }

        private void PA_Graafik2_Click(object sender, EventArgs e)
        {
            Pliiats1.Color = Color.Red;
            Pliiats1.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            Pliiats1.Width = 5;

            float x1 = (float)xalg;
            float y1 = (float)F1(x1);
            for(float x2 = (float)xalg; x2 <= xlopp; x2 += 0.01f)
            {
                float y2 = (float)F1(x2);
                if (Math.Abs(y2 - y1) < (ylopp - yalg))
                    g.DrawLine(Pliiats1, ((float)x1 - (float)xalg) * (float)xpoint, (float)(ylopp - y1) * (float)ypoint, (float)(x2 - xalg) * (float)xpoint, (float)(ylopp - y2) * (float)ypoint);
                x1 = x2;
                y1 = y2;
            }
            PA_PictureBox.Image = bmp;
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

            Teljed();

        }

        private void Teljed()
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
            for (int ix = 0; ix <= nxx * 10; ix++)
            {
                g.DrawLine(Pliiats2, ix * dx / 5, (ny0 * dy) - 6, ix * dx / 5, (ny0 * dy) + 6);
            }
            for (int iy = 0; iy <= nyy; iy++)
            {
                g.DrawLine(Pliiats1, 0, iy * dy, GBlaius, iy * dy);
                g.DrawLine(Pliiats3, (nx0 * dx) - 15, iy * dy, (nx0 * dx) + 15, iy * dy);
            }
            for (int iy = 0; iy <= nyy * 10; iy++)
            {
                g.DrawLine(Pliiats3, (nx0 * dx) - 6, iy * dy / 5, (nx0 * dx) + 6, iy * dy / 5);
            }


            g.DrawLine(Pliiats3, nx0 * dx, 0, nx0 * dx, GBkorgus);
            g.DrawLine(Pliiats3, 0, ny0 * dy, GBlaius, ny0 * dy);

        }

        private double F1(double x)
        {
            double y = 0;
            double a1 = Convert.ToInt32(PA_SinArv.Text);
            if (PA_SinM.Text == "-") a1 = -a1;
            y += a1*Math.Sin(x);

            double a2 = Convert.ToInt32(PA_CosArv.Text);
            if (PA_CosM.Text == "-") a2 = -a2;
            y += a2*Math.Cos(x);

            double a3 = Convert.ToInt32(PA_TgArv.Text);
            if (PA_TgM.Text == "-") a3 = -a3;
            y += a3*Math.Tan(x);

            double a4 = Convert.ToInt32(PA_CTgArv.Text);
            if (PA_CtgM.Text == "-") a4 = -a4;
            y += a4 * Math.Cos(x) / Math.Sin(x);

            return y;
        }

        private void PA_Graafik_Click(object sender, EventArgs e)
        {
            if (PA_SinArv.Text == "")
            {
                PA_SinArv.Text = "0";
            }
            if (PA_CosArv.Text == "")
            {
                PA_CosArv.Text = "0";
            }
            if (PA_TgArv.Text == "")
            {
                PA_TgArv.Text = "0";
            }
            if (PA_CTgArv.Text == "")
            {
                PA_CTgArv.Text = "0";
            }

            float nxx = (float)xlopp - (float)xalg;
            float nyy = (float)ylopp - (float)yalg;
           
            float dx = (float)GBlaius / nxx;
            float dy = (float)GBkorgus / nyy;

            int nx0 = GBlaius / 2;
            int ny0 = GBkorgus / 2;
            



            float x1 =(float) xalg;
            float y1 = (float)F1(x1);
            
            for (float x2 = (float)xalg; x2 <= xlopp; x2 += 0.01f)
            {
                float y2 = (float)F1(x2);
                float y2y1 = Math.Abs(y1*dy) + Math.Abs(y2*dy);
                if (y2y1 < GBkorgus )
                {
                    g.DrawLine(Pliiats5, (x1 * dx + nx0), (ny0 - y1 * dy), (x2 * dx + nx0), (ny0 - y2 * dy));
                    x1 = x2;
                    y1 = y2;
                    
                }
                else
                {
                    g.DrawLine(Pliiats2_2, (x1 * dx + nx0), (ny0 - y1 * dy), (x2 * dx + nx0), (ny0 - y2 * dy));
                    x1 = x2;
                    y1 = y2;
                }
            }




        }


    }
}
