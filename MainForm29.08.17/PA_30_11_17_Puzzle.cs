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
        PictureBox[] picMasPBox;
        PictureBox[] picMasGBox;
        int select = -1;
        int kx = 3, ky = 4;

        public PA_30_11_17_Puzzle()
        {
            InitializeComponent();
            PA_Samm2.Enabled = false;
            PA_Samm3.Enabled = false;
            
        }

        private void PA_Samm1_Click(object sender, EventArgs e)
        {
            PA_pictureBox1.Image = null;
            PA_pictureBox1.Width = 564;
            PA_pictureBox1.Height = 570;

            PA_groupBox1.Width = 564;
            PA_groupBox1.Height = 570;

            string filepath = "";
            PA_openFileDialog1.Filter = " Image |*.bmp; *.jpg;*.png|All files(*.*)|*.*";
            PA_openFileDialog1.FileName = "";//чтобы при отмене выбора переменная пути оставалаь пустой
            PA_openFileDialog1.ShowDialog(); // открыть эесплорер фаилов
            filepath = PA_openFileDialog1.FileName; //сохрать путь к фаилу в переменную 
            string filename = Path.GetFileName(filepath);
            
            


            if (filepath == "")
            {
                return;//остановится если не сохранен не какой путь к фаилу
            }
            Image img = Image.FromFile(filepath);
            int PicBoxH = PA_pictureBox1.Height;
            int PicBoxW = PA_pictureBox1.Width;
            int imgH = img.Height;
            int imgW = img.Width;
            float imgSuhe = (float)imgW / imgH;

            if (imgH < imgW)
            {
                imgW = PicBoxW;
                imgH = (int)(imgW/imgSuhe);
            }
            else
            {
                imgH = PicBoxH;
                imgW = (int)(imgH *imgSuhe);
            }



            PA_pictureBox1.Width = imgW;
            PA_pictureBox1.Height = imgH;

            PA_groupBox1.Width = imgW;
            PA_groupBox1.Height = imgH;

            PA_pictureBox1.Image = img;

            
            PA_Samm2.Enabled =true;
        }

        private void PA_Samm2_Click(object sender, EventArgs e)
        {
            

            picMasPBox = new PictureBox[kx * ky];
            picMasGBox = new PictureBox[kx * ky];

            int PW = PA_pictureBox1.Width/kx;
            int PH = PA_pictureBox1.Height/ky;

            Image img = PA_pictureBox1.Image;
            int RecH = img.Height / ky;
            int RecW = img.Width / kx;


            for (int i = 0; i < ky; i++)
            {
                for (int y = 0; y < kx; y++)
                {
                    int k = i * kx + y;

                    picMasPBox[k] = new PictureBox();                                    
                    PA_pictureBox1.Controls.Add(picMasPBox[k]);
                    picMasPBox[k].Width = PW;
                    picMasPBox[k].Height = PH;                   
                    picMasPBox[k].Top = (PH) * i;
                    picMasPBox[k].Left = (PW) * y;
                    picMasPBox[k].BorderStyle = BorderStyle.FixedSingle;
                    picMasPBox[k].SizeMode = PictureBoxSizeMode.Zoom;
                    picMasPBox[k].Click += new EventHandler(picMasPBoxPic_Click);
                    picMasPBox[k].Enabled = false;


                    int FomTop = RecH * i;
                    int FromLeft = RecW * y;
                    Bitmap BitmapSourseIMG = new Bitmap(img);
                    Bitmap CutFromIMG = new Bitmap(RecW, RecH);
                    using (Graphics gr = Graphics.FromImage(CutFromIMG))
                    {
                        Rectangle SoureseRectangle = new Rectangle(FromLeft, FomTop, RecW, RecH);
                        Rectangle DestRectangle = new Rectangle(0, 0, RecW, RecH);
                        gr.DrawImage(BitmapSourseIMG, DestRectangle, SoureseRectangle, GraphicsUnit.Pixel);
                    }
                    picMasPBox[k].Image = CutFromIMG;
                   





                    picMasGBox[k] = new PictureBox();                               
                    PA_groupBox1.Controls.Add(picMasGBox[k]);
                    picMasGBox[k].Width = PW;
                    picMasGBox[k].Height = PH;
                    picMasGBox[k].Top = (PH) * i;
                    picMasGBox[k].Left = (PW) * y;
                    picMasGBox[k].BorderStyle = BorderStyle.FixedSingle;
                    picMasGBox[k].SizeMode = PictureBoxSizeMode.Zoom;
                    picMasGBox[k].Click += new EventHandler(picMasGBoxPic_Click);
                    picMasGBox[k].Enabled = false;
                }
               


            }



            PA_Samm3.Enabled = true;
            PA_Samm2.Enabled = false;
            PA_Samm1.Enabled = false;
        }




        private void PA_Samm3_Click(object sender, EventArgs e)
        {
            Random Random = new Random();
            int[] num=new int[kx*ky];
            for (int i = 0; i < kx * ky; i++) num[i] = -1;
            for (int i = 0; i< kx * ky; i++)
            {
                int n;
                do
                {
                    n = Random.Next(kx * ky);
                } while (num[n] >= 0);
                num[n] = i;

                picMasGBox[i].Image = picMasPBox[n].Image;
                picMasPBox[n].Image = null;
                picMasGBox[i].Enabled = true;
                picMasPBox[i].Enabled = true;

            }
           


           


            PA_Samm3.Enabled = false;
        }



        private void picMasGBoxPic_Click(object sender, EventArgs e)
        {
            select = Array.IndexOf(picMasGBox, (PictureBox)sender);
        }




        private void picMasPBoxPic_Click(object sender, EventArgs e)
        {
            //if (select < 0) return;
            
        }

        
    }
}
