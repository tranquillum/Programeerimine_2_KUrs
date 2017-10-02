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
    public partial class PA_29_09_2017 : Form
    {
        float nx = 8, ny = 10;
        
        float x1, x2, y1, y2, joonLaius;
        Pen Pliiats = new Pen(Color.Black, 1);// (цвет и тощина)
        SolidBrush Pintset = new SolidBrush(Color.Green);
        Graphics g;


        Random r = new Random();
        int GBlaius, GBkorgus;
        public PA_29_09_2017()
        {
            InitializeComponent();
            GBlaius = PA_pictureBox.Width;
            GBkorgus = PA_pictureBox.Height;
            g = Graphics.FromHwnd(PA_pictureBox.Handle);
        }

        private void PA_Eelopsid_Click(object sender, EventArgs e)
        {
            float t1 = GBlaius / nx;
            float t2 = GBkorgus / ny;
            

            
            for (int i = 0; i <=  nx; i+=2 )
            {
                for (int y = 0; y <=ny; y += 2)
                {
                    x1 = t1*i;
                    y1 = t2*y;
                    x2 = t1;
                    y2 = t2;
                    g.DrawEllipse(Pliiats, x1, y1, x2, y2);
                } 
            }

            for (int i = 1; i <= nx; i += 2)
            {
                for (int y = 1; y <= ny; y += 2)
                {
                    x1 = t1 * i;
                    y1 = t2 * y;
                    x2 = t1;
                    y2 = t2;
                    g.DrawEllipse(Pliiats, x1, y1, x2, y2);
                }
            }
        }

        private void PA_Eelopsid2_Click(object sender, EventArgs e)
        {

            for (int i = 0; i <= nx; i ++)
            {
                float t1 = GBlaius / nx;
                float t2 = GBkorgus / ny;

                    x1 = t1*i;
                    y1 = 0 ;
                    x2 = t1;
                    y2 = GBkorgus;
                    g.DrawEllipse(Pliiats, x1, y1, x2, y2);
                
            }
        }

        private void PA_Ruudustik_Click(object sender, EventArgs e)
        {
            for(float i = 0; i <= nx; i++)
            {
                
                float t = GBlaius / nx;
                x1 = t*i;
                y1 = 0;
                x2 = t*i;
                y2 = GBkorgus;
                Pliiats.Width = 1;
                g.DrawLine(Pliiats, x1, y1, x2, y2);
            }
            for (float i = 0; i <= ny; i++)
            {
                
                float t = GBkorgus / ny;
                x1 = 0;
                y1 = t * i;
                x2 = GBlaius;
                y2 = t * i;
                Pliiats.Width = 1;
                g.DrawLine(Pliiats, x1, y1, x2, y2);
            }

        }
        
        private void PA_Diagonaalid_Click(object sender, EventArgs e)
        {
            
            float xt = nx+ny;
            
            for (float i = -ny; i <= nx+ny; i++)
            {
                float t1 = GBlaius / nx;
                float t2 = GBkorgus / ny;
                
                x1 = t1 * i;
                y1 = 0;
                x2 = GBlaius;
                y2 = t2 * xt;
                xt--;

                g.DrawLine(Pliiats, x1, y1, x2, y2);
            }
            
            


        }

        private void PA_Diagonaalid2_Click(object sender, EventArgs e)
        {
            for (float i = 0; i <= ny + nx; i++)
            {
                float t1 = GBlaius / nx;
                float t2 = GBkorgus / ny;
                x1 = 0;
                y1 = t2 * i;
                x2 = t1 * i;
                y2 = 0;

                g.DrawLine(Pliiats, x1, y1, x2, y2);
            }

        }

        private void PA_Eelips_Click(object sender, EventArgs e)
        {
            float t1 = GBlaius / nx;
            float t2 = GBkorgus / ny;

            x2 = GBlaius;
            y2 = GBkorgus;


            for (float i = 0; i <= ny+nx ; i++)
            {
                
                if (x2 > t1*2 && y2 > t2*2)
                {
                    
                    x1 = t1 * i;
                    y1 = t2 * i;
                    x2 = GBlaius - t1 * 2 * i;
                    y2 = GBkorgus - t2 * 2 * i;


                    
                }
                g.DrawEllipse(Pliiats, x1, y1, x2-1, y2-1);
            }



        }



        private void Juhuarvud()
        {
            x1 = r.Next(GBlaius);
            x2 = r.Next(GBlaius);
            y1 = r.Next(GBkorgus);
            y2 = r.Next(GBkorgus);
            joonLaius = r.Next(1, 10);

            PA_X1koordinaat.Text = x1.ToString();
            PA_X2koordinaat.Text = x2.ToString();
            PA_Y1koordinaat.Text = y1.ToString();
            PA_Y2koordinaat.Text = y2.ToString();
            PA_JoonLaius.Text = joonLaius.ToString();
            Pliiats.Width = r.Next(5, 15);
            int varv = r.Next(54);
            int punane = r.Next(254);
            int roheline = r.Next(254);
            int sinine = r.Next(254);
            Pliiats.Color = Color.FromArgb(punane, roheline, sinine);
        }


        private void PA_Joon_Click(object sender, EventArgs e)
        {
            Juhuarvud();
            g.DrawLine(Pliiats, x1, y1, x2, y2);


        }
    }
}
