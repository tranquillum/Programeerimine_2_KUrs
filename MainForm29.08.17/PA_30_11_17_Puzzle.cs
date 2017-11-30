using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm29._08._17
{
    public partial class PA_30_11_17_Puzzle : Form
    {
        PictureBox[] picMas;

        public PA_30_11_17_Puzzle()
        {
            InitializeComponent();
            PA_Samm2.Enabled = false;
            PA_Samm3.Enabled = false;
        }

        private void PA_Samm1_Click(object sender, EventArgs e)
        {
            string filepath = "";
            PA_openFileDialog1.Filter = " Image |*.bmp; *.jpg|All files(*.*)|*.*";
            PA_openFileDialog1.FileName = "";//чтобы при отмене выбора переменная пути оставалаь пустой
            PA_openFileDialog1.ShowDialog(); // открыть эесплорер фаилов
            filepath = PA_openFileDialog1.FileName; //сохрать путь к фаилу в переменную 
            string filename = Path.GetFileName(filepath);
            
            


            if (filepath == "")
            {
                return;//остановится если не сохранен не какой путь к фаилу
            }
            Image pilt = Image.FromFile(filepath);
            int picH = pilt.Height;
            int picW = pilt.Width;

            if (picH > picW)
            {
                var suhe = picH/ PA_pictureBox1.Height;
                picH = PA_pictureBox1.Height;
                PA_pictureBox1.Width  = picW * suhe;

            }
            else if (picH < picW)
            {
                var suhe = picW / PA_pictureBox1.Width;
                picW = PA_pictureBox1.Width;
                PA_pictureBox1.Height = picH * suhe;
            }

            //PA_pictureBox1.Width = picW;
            //PA_pictureBox1.Height = picH;

            //PA_groupBox1.Width = picW;
            //PA_groupBox1.Height = picH;

            PA_pictureBox1.Image = Image.FromFile(filepath);


            PA_Samm2.Enabled =true;
        }

        private void PA_Samm2_Click(object sender, EventArgs e)
        {
            int kx = 3, ky = 4;

            picMas = new PictureBox[kx * ky];

            int Pww = PA_pictureBox1.Width/kx;
            int Phh = PA_pictureBox1.Height/ky;

            int Gww = PA_groupBox1.Width;
            int Ghh = PA_groupBox1.Height;


            for (int i = 0; i < ky; i++)
            {
                for (int y = 0; y < kx; y++)
                {
                    int k = i * kx + y;

                    picMas[k] = new PictureBox();
                    picMas[k].Image = null;
                    PA_pictureBox1.Controls.Add(picMas[k]);
                    PA_groupBox1.Controls.Add(picMas[k]);
                    picMas[k].Width = Pww;
                    picMas[k].Height = Phh;                   
                    picMas[k].Top = (Phh) * i;
                    picMas[k].Left = (Pww) * y;
                    picMas[k].BorderStyle = BorderStyle.FixedSingle;
                    picMas[k].SizeMode = PictureBoxSizeMode.StretchImage;


                }
               


            }



            PA_Samm3.Enabled = true;
        }
    }
}
