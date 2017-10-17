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
    public partial class PA_12_10_2017 : Form
    {

        float x1, x2, y1, y2;
        Pen Pliiats = new Pen(Color.Black, 2);
        Pen Pliiats2 = new Pen(Color.Gray, 1);
        SolidBrush Pintset = new SolidBrush(Color.Green);
        Graphics g;
        int GBlaius, GBkorgus;


        public PA_12_10_2017()
        {
            InitializeComponent();
            GBlaius = PA_PictureBox.Width-1;
            GBkorgus = PA_PictureBox.Height-1;
            g = Graphics.FromHwnd(PA_PictureBox.Handle);
            PA_ZeroLeft.Visible = false;
            PA_ZeroRight.Visible = false;
        }

        private void PA_12_10_2017_Load(object sender, EventArgs e)
        {

        }

        

        private void PA_drawbtn_Click(object sender, EventArgs e)
        {
            XTeljed();
            YTeljed();
            Graafik();

        }

        private void PA_m1_Click(object sender, EventArgs e)
        {
            if (PA_m1.Text == "+") PA_m1.Text = "-"; else PA_m1.Text = "+";
        }

        private void PA_m2_Click(object sender, EventArgs e)
        {
            if (PA_m2.Text == "+") PA_m2.Text = "-"; else PA_m2.Text = "+";
        }

        private void PA_Claen_Click(object sender, EventArgs e)
        {
            PA_PictureBox.Image = null;
            PA_ZeroLeft.Visible = false;
            PA_ZeroRight.Visible = false;
        }

        private void PA_m3_Click(object sender, EventArgs e)
        {
            if (PA_m3.Text == "+") PA_m3.Text = "-"; else PA_m3.Text = "+";
        }

        private void PA_m4_Click(object sender, EventArgs e)
        {
            if (PA_m4.Text == "+") PA_m4.Text = "-"; else PA_m4.Text = "+";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private float F1 (float x)
        {
            float y = 0;
            int a1 = Convert.ToInt32(PA_arv1.Text);
            if (PA_m1.Text == "-") a1 = -a1;
            y += a1 * x * x * x;
            
            int a2 = Convert.ToInt32(PA_arv2.Text);
            if (PA_m2.Text == "-") a2 = -a2;
            y += a2 * x *x ;
            
            int a3= Convert.ToInt32(PA_arv3.Text);
            if (PA_m3.Text == "-") a3 = -a3;
            y += a3 * x  ;
            
            int a4 = Convert.ToInt32(PA_arv4.Text);
            if (PA_m4.Text == "-") a4 = -a4;
            y += a4;



            return y;
        }


        private void XTeljed()
        {

            float x1get = Math.Abs(Convert.ToInt32(PA_x1.Text));
            float x2get = Math.Abs(Convert.ToInt32(PA_x2.Text));
            
            if (Convert.ToInt32(PA_x1.Text) < 0 && Convert.ToInt32(PA_x2.Text) > 0)
            {

                float tget = x1get + x2get;
                float t = GBlaius / tget;

                x1 = 0;        
                x2 = 0;

                for (float i = 0; i <= x1get; i++)
                {
                    x1 = t * i;
                    x2 = t * i;
                    if (i < x1get)
                    {
                        g.DrawLine(Pliiats2, x1, 0, x2, GBkorgus);
                        
                    }

                    if (i == x1get)
                    {
                        g.DrawLine(Pliiats, x1, 0, x2, GBkorgus);
                        

                        for (float y = x1get + 1; y <= x1get + x2get; y++)
                        {
                            x1 = t * y;
                            x2 = t * y;
                            g.DrawLine(Pliiats2, x1, 0, x2, GBkorgus);
                        }
                    }
                }
            }
            else if(Convert.ToInt32(PA_x1.Text) >= 0 && Convert.ToInt32(PA_x2.Text) > 0)
            {
                float tget = x2get-x1get;
                float t = GBlaius / tget;
                if (Convert.ToInt32(PA_x1.Text)==0)
                {
                    g.DrawLine(Pliiats, 1, 0, 1, GBkorgus);
                }
                else
                {
                    PA_ZeroLeft.Visible = true;
                }
                for (float y = 0; y <=  x2get; y++)
                {
                    x1 = t * y;
                    x2 = t * y;
                    g.DrawLine(Pliiats2, x1, 0, x2, GBkorgus);
                }
            }
            else if (Convert.ToInt32(PA_x2.Text) <= 0 && Convert.ToInt32(PA_x1.Text) < 0)
            {
                float tget = x1get - x2get;
                float t = GBlaius / tget;

                if (Convert.ToInt32(PA_x2.Text) == 0)
                {
                    g.DrawLine(Pliiats, GBlaius, 0, GBlaius, GBkorgus);
                }
                else
                {
                    PA_ZeroRight.Visible = true;
                }

                for (float y = 0; y <= x1get; y++)
                {
                    x1 = t * y;
                    x2 = t * y;
                    g.DrawLine(Pliiats2, x1, 0, x2, GBkorgus);
                }
            }  
        }




        private void YTeljed()
        {
            
            PA_y2.Text = Convert.ToString(F1(Convert.ToInt32(PA_x2.Text)));
            PA_y1.Text = Convert.ToString(F1(Convert.ToInt32(PA_x1.Text)));
            float y1counted = F1(Convert.ToInt32(PA_x1.Text));
            float y2counted = F1(Convert.ToInt32(PA_x2.Text));
            float y1get = Math.Abs(F1(Convert.ToInt32(PA_x1.Text)));
            float y2get = Math.Abs(F1(Convert.ToInt32(PA_x2.Text)));

            if (y1counted < 0 && y2counted > 0)
            {

                float tget = y1get + y2get;
                float t = GBkorgus / tget;

                y1 = 0;
                y2 = 0;

                for (float i = 0; i <= y2get; i++)
                {
                    y1 = t * i;
                    y2 = t * i;
                    if (i < y2get)
                    {
                        g.DrawLine(Pliiats2, 0, y1, GBlaius, y2);
                    }

                    if (i == y2get)
                    {
                        g.DrawLine(Pliiats, 0, y1, GBlaius, y2);

                        for (float y = y1get + 1; y <= y1get + y2get; y++)
                        {
                            y1 = t * y;
                            y2 = t * y;
                            g.DrawLine(Pliiats2, 0, y1, GBlaius, y2);

                        }
                    }
                }
            }
            else if (y1counted >= 0 && y2counted > 0)
            {
                float tget = y2get - y1get;
                float t = GBkorgus / tget;
                if (y1counted == 0)
                {
                    g.DrawLine(Pliiats, 0, GBkorgus-1, GBlaius, GBkorgus - 1);
                }
                else
                {
                    PA_ZeroUP.Visible = true;
                }
                for (float y = 0; y <= y2get; y++)
                {
                    y1 = t * y;
                    y2 = t * y;
                    g.DrawLine(Pliiats2, 0, y1, GBlaius, y2);
                }
            }
            else if (y2counted <= 0 && y1counted < 0)
            {
                float tget = y1get - y2get;
                float t = GBkorgus / tget;

                if (y2counted == 0)
                {
                    g.DrawLine(Pliiats, 0, 0, GBlaius, 0);
                }
                else
                {
                    PA_ZeroDown.Visible = true;
                }

                for (float y = 0; y <= y1get; y++)
                {
                    x1 = t * y;
                    x2 = t * y;
                    g.DrawLine(Pliiats2, x1, 0, x2, GBkorgus);
                }
            }
        }

        private void Graafik()
        {
            float x1get = Math.Abs(Convert.ToInt32(PA_x1.Text));
            float x2get = Math.Abs(Convert.ToInt32(PA_x2.Text));
            float y1get = Math.Abs(F1(Convert.ToInt32(PA_x1.Text)));
            float y2get = Math.Abs(F1(Convert.ToInt32(PA_x2.Text)));

            float x1t = Convert.ToInt32(PA_x1.Text);
            float x2t = Convert.ToInt32(PA_x2.Text);

            float tget = x1get + x2get;
            float ttget = y1get + y2get;

            float t = GBlaius / tget;
            float tt = GBkorgus / ttget;
            x2 = 0;
            y2 = GBkorgus;
            for (float i = x1t; i <= x2t;  i++)
            {
                x1 = x2;
                y1 = y2;
                x2 = x1+t;
                
                y2 = F1(i+1);
                if (y2 < 0)
                {
                    y2 = GBkorgus/2 + Math.Abs(y2);
                }
                else y2 = GBkorgus/2 - Math.Abs(y2);

                g.DrawLine(Pliiats, x1, y1, x2, y2);

            }


        }

        private void Graafik2()
        {
            float x1get = Math.Abs(Convert.ToInt32(PA_x1.Text));
            float x2get = Math.Abs(Convert.ToInt32(PA_x2.Text));
            float txget = x1get + x2get;

            float y1get = Math.Abs(F1(Convert.ToInt32(PA_x1.Text)));
            float y2get = Math.Abs(F1(Convert.ToInt32(PA_x2.Text)));
            float tyget = y1get + y2get;
            float dx = (float)PA_PictureBox.Width / txget;
            float dy = (float)PA_PictureBox.Height / tyget;

            Pliiats.Width = 1;
            Pliiats.Color = Color.Gray;
            Pliiats.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            for (int ix = 0; ix <= txget; ix++)
                g.DrawLine(Pliiats, ix * dx, 0, ix * dx, GBkorgus);//!!!!!
            for (int iy = 0; iy <= tyget; iy++)
                g.DrawLine(Pliiats, 0,iy*dy,GBlaius,iy*dy);//!!!!!

            Pliiats.Width = 3;
            Pliiats.Color = Color.Black;
            Pliiats.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            int nx0 = nx / 2;
            int ny0 = ny / 2;
            



        }




    }
}
