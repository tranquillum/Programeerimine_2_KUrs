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
            F1(Convert.ToInt32(PA_x1.Text));
            F1(Convert.ToInt32(PA_x2.Text));



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

        private float F1 (float x)
        {
            float y = 0;
            int a4 = Convert.ToInt32(PA_arv4.Text);
            if (PA_m4.Text == "-") a4 = -a4;
            y += a4 * x * x * x;
            
            int a3 = Convert.ToInt32(PA_arv3.Text);
            if (PA_m3.Text == "-") a3 = -a3;
            y += a3 * x *x ;
            
            int a2= Convert.ToInt32(PA_arv2.Text);
            if (PA_m2.Text == "-") a2 = -a2;
            y += a4 * x  ;
            
            int a1 = Convert.ToInt32(PA_arv1.Text);
            if (PA_m1.Text == "-") a1 = -a1;
            y += a1;



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
                float t = GBlaius / x2get;
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
                float tget = x1get + x2get;
                float t = GBlaius / x1get;

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





    }
}
