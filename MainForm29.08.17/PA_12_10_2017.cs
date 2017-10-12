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
        Pen Pliiats = new Pen(Color.Black, 1);
        SolidBrush Pintset = new SolidBrush(Color.Green);
        Graphics g;
        int GBlaius, GBkorgus;


        public PA_12_10_2017()
        {
            InitializeComponent();
            GBlaius = PA_PictureBox.Width;
            GBkorgus = PA_PictureBox.Height;
            g = Graphics.FromHwnd(PA_PictureBox.Handle);
        }

        private void PA_12_10_2017_Load(object sender, EventArgs e)
        {

        }

        

        private void PA_drawbtn_Click(object sender, EventArgs e)
        {

            g.DrawLine(Pliiats, 0, GBkorgus / 2, GBlaius, GBkorgus / 2);
            float x1get = Convert.ToInt32(PA_x1.Text);
            float x2get = Convert.ToInt32(PA_x2.Text);


            float xt = Math.Abs(x1get) + Math.Abs( x2get);

            for (float i = -1; i <= xt; i++)
            {

                float t = GBlaius / xt;
                x1 = t * i;
                y1 = 0;
                x2 = t * i;
                y2 = GBkorgus;
                Pliiats.Width = 1;
                g.DrawLine(Pliiats, x1, y1, x2, y2);
            }




        }

        private void PA_m1_Click(object sender, EventArgs e)
        {
            if (PA_m1.Text == "+") PA_m1.Text = "-"; else PA_m1.Text = "+";
        }

        private void PA_m2_Click(object sender, EventArgs e)
        {
            if (PA_m2.Text == "+") PA_m2.Text = "-"; else PA_m2.Text = "+";
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






            return y;
        }


    }
}
