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
        public PA_09_11_17_File()
        {
            InitializeComponent();
        }
        string filenimi = "";
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
            

        }
        private void PA_groupBox1_CheckedChanged(Object sender,EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (PA_NormalIMG.Checked == true)
            {
                PA_IMGBox.Image = null;
                PA_IMGBox.SizeMode = PictureBoxSizeMode.Normal;
                PA_IMGBox.Image = System.Drawing.Image.FromFile(filenimi);
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

        }


    }
}
