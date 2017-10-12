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
            Teljed();
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
            y += a3 * x *x * x;
            
            int a2= Convert.ToInt32(PA_arv2.Text);
            if (PA_m2.Text == "-") a2 = -a2;
            y += a4 * x * x * x;
            
            int a1 = Convert.ToInt32(PA_arv1.Text);
            if (PA_m1.Text == "-") a1 = -a1;
            y += a1 * x * x * x;



            return y;
        }
        private void Teljed()
        {
            g.DrawLine(Pliiats, 0, GBkorgus / 2, GBlaius, GBkorgus / 2);
            g.DrawLine(Pliiats, GBlaius / 2, 0, GBlaius / 2, GBkorgus);

            float x1get = Math.Abs(Convert.ToInt32(PA_x2.Text));
            float x2get = Math.Abs(Convert.ToInt32(PA_x1.Text));
             




            float tget = x1get + x2get + 1;
            float t = GBlaius / tget;
            x1 = GBlaius / 2;
            y1 = (GBkorgus / 2) + 5;
            x2 = GBlaius / 2;
            y2 = (GBkorgus / 2) - 5;



            for (float i = 0; i <= x1get; i++)
            {
                x1 = (GBlaius / 2) + (t * i);
                y1 = (GBkorgus / 2) + 5;
                x2 = (GBlaius / 2) + (t * i);
                y2 = (GBkorgus / 2) - 5;

                g.DrawLine(Pliiats, x1, y1, x2, y2);

            }
            for (float i = 0; i <= x2get; i++)
            {
                x1 = (GBlaius / 2) - (t * i);
                y1 = (GBkorgus / 2) + 5;
                x2 = (GBlaius / 2) - (t * i);
                y2 = (GBkorgus / 2) - 5;

                g.DrawLine(Pliiats, x1, y1, x2, y2);
            }
        }

    }
}
