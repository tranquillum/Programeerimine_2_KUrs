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
    public partial class PA_09_11_17_File : Form
    {


        string filenimi = "";
        Bitmap OriginalImage;

         bool IsSelecting = false;
        int x0, y0, x1, y1;

        public PA_09_11_17_File()
        {
            InitializeComponent();
            
        }
        





        private void PA_FileValik_Click(object sender, EventArgs e)
        {
            PA_openFileDialog1.Filter = " Image |*.bmp; *.jpg|All files(*.*)|*.*";
            PA_openFileDialog1.FileName = "";//чтобы при отмене выбора переменная пути оставалаь пустой
            PA_openFileDialog1.ShowDialog(); // открыть эесплорер фаилов
            filenimi = PA_openFileDialog1.FileName; //сохрать путь к фаилу в переменную    
            


            if (filenimi == "")
            {
                return;//остановится если не сохранен не какой путь к фаилу
            }



            PA_IMGBox.Image = System.Drawing.Image.FromFile(filenimi);
            
            if (PA_NormalIMG.Checked == true)
            {
                PA_IMGBox.SizeMode = PictureBoxSizeMode.Normal;
            }
            else if (PA_StrethIMG.Checked == true)
            {
                PA_IMGBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (PA_AutoSizeIMG.Checked == true)
            {
                PA_IMGBox.SizeMode = PictureBoxSizeMode.AutoSize;
            }
            else if (PA_CentralIMG.Checked == true)
            {
                PA_IMGBox.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else if (PA_ZoomIMG.Checked == true)
            {
                PA_IMGBox.SizeMode = PictureBoxSizeMode.Normal;
            }
            else 
            {
                return;
            }

            Image pilt = Image.FromFile(filenimi);
            int w = pilt.Width;
            int h = pilt.Height;
            PA_Resolution.Text = w.ToString() + "X" + h.ToString();
            OriginalImage = new Bitmap(PA_IMGBox.Image);

        }

        private void PA_IMGBox_Click(object sender, EventArgs e)
        {

        }

        private void PA_09_11_17_File_Load(object sender, EventArgs e)
        {
            
        }

        private void PA_IMGBox_MouseDown(object sender, MouseEventArgs e)
        {

            IsSelecting = true;

            
            x0 = e.X;
            y0 = e.Y;
        }

        private void PA_IMGBox_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (!IsSelecting) return;

            x1 = e.X;
            y1 = e.Y;

            // Make a Bitmap to display the selection rectangle.
            Bitmap bm = new Bitmap(OriginalImage);

            // Draw the rectangle.
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.DrawRectangle(Pens.Red,
                    Math.Min(x0, x1), Math.Min(y0, y1),
                    Math.Abs(x0 - x1), Math.Abs(y0 - y1));
            }

            // Display the temporary bitmap.
            PA_IMGBox.Image = bm;
        }

        private void PA_IMGBox_MouseUp(object sender, MouseEventArgs e)
        {
            // Do nothing it we're not selecting an area.
            if (!IsSelecting) return;
            IsSelecting = false;

            // Display the original image.
            PA_IMGBox.Image = OriginalImage;

            // Copy the selected part of the image.
            int wid = Math.Abs(x0 - x1);
            int hgt = Math.Abs(y0 - y1);
            if ((wid < 1) || (hgt < 1)) return;

            Bitmap area = new Bitmap(wid, hgt);
            using (Graphics gr = Graphics.FromImage(area))
            {
                Rectangle source_rectangle =
                    new Rectangle(Math.Min(x0, x1), Math.Min(y0, y1), wid, hgt);
                Rectangle dest_rectangle =
                    new Rectangle(0, 0, wid, hgt);
                gr.DrawImage(OriginalImage, dest_rectangle,
                    source_rectangle, GraphicsUnit.Pixel);
            }


            PA_IMGBox2.Image = area;
        }



    }
}
