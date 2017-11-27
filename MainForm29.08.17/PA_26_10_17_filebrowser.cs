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
    public partial class PA_26_10_17_filebrowser : Form
    {

        int piccounter = 0;
        string filepath = "";
        int kx = 3, ky = 4;
        PictureBox[] picMas;
        Label[] lableMas;
        public PA_26_10_17_filebrowser()
        {
            InitializeComponent();
            PA_File.Enabled = false;
            PA_Files.Enabled = false;
        }

        private void PA_File_Click(object sender, EventArgs e)
        {
            PA_openFileDialog1.Filter = " Image |*.bmp; *.jpg|All files(*.*)|*.*";
            PA_openFileDialog1.FileName = "";//чтобы при отмене выбора переменная пути оставалаь пустой
            PA_openFileDialog1.ShowDialog(); // открыть эесплорер фаилов
            filepath = PA_openFileDialog1.FileName; //сохрать путь к фаилу в переменную 
            string filename = Path.GetFileName(filepath);
            

            if (filepath == "")
            {
                return;//остановится если не сохранен не какой путь к фаилу
            }


            if (piccounter < kx * ky)
            {
                picMas[piccounter].Image = Image.FromFile(filepath); //втавить картинку в пикчер бокс в пичербоес.
                lableMas[piccounter].Text = filename;
                piccounter++;
            } 
            else
            {
                MessageBox.Show("Kõik kohad on kinni", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void PA_Files_Click(object sender, EventArgs e)
        {



            PA_openFileDialog1.Multiselect = true;
            PA_openFileDialog1.Filter = " Image |*.bmp; *.jpg|All files(*.*)|*.*";
            PA_openFileDialog1.FileName = "";//чтобы при отмене выбора переменная пути оставалаь пустой
            PA_openFileDialog1.ShowDialog(); // открыть эесплорер фаилов
            string [] filepaths = PA_openFileDialog1.FileNames; //сохрать путь к фаилу в переменную 
            string[] filenames=new string[filepaths.Length];

            

            for(int i =0; i < filepaths.Length; i++)
            {
                filenames[i] = Path.GetFileName(filepaths[i]);
                picMas[i].Image = Image.FromFile(filepaths[i]);
                lableMas[i].Text = filenames[i];
            }


        }

        private void PA_ButtonMassiiv_Click(object sender, EventArgs e)
        {
            picMas = new PictureBox[kx * ky];
            lableMas=new Label[kx*ky];
            int ww = PA_FileBox.Width / kx; //разделить ширину гроупбокса на количество обьектов по горизонтали получить размер одной ячкйки по горизонтали
            int hh = PA_FileBox.Height / ky;// разделить высоту гроупбокаса на количество обьектов по вертикали получить рамер одной ячейки по вертикали
            int ww1 = ww * 9 / 10;
            int ww2 = (ww - ww1) / 2;
            int hh1 = hh * 8 / 10;
            int hh2 = (hh - hh1) / 5;



            for (int i = 0; i < ky; i++)
            {
                for (int y = 0; y < kx; y++)
                {

                    int k = i * kx + y;


                    lableMas[k] = new Label();
                    lableMas[k].Font = new Font("Courier New", 8, FontStyle.Bold);
                    lableMas[k].BackColor = Color.Red;
                    lableMas[k].AutoSize = false;
                    lableMas[k].TextAlign = ContentAlignment.MiddleCenter;
                    PA_FileBox.Controls.Add(lableMas[k]);
                    lableMas[k].Left = ww * y + ww2;
                    lableMas[k].Top = hh * i + hh1 + 2 * hh2;
                    lableMas[k].Width = ww1;
                    lableMas[k].Height = 2 * hh2;
                    lableMas[k].Text = "XXX";

                    picMas[k] = new PictureBox();
                    picMas[k].Image = null;
                    PA_FileBox.Controls.Add(picMas[k]);
                    picMas[k].Width = ww1;
                    picMas[k].Height = hh1;
                    picMas[k].BackColor = Color.Black;
                    picMas[k].Top = (hh) * i + hh2;
                    picMas[k].Left = (ww) * y+ww2;                  
                    picMas[k].BorderStyle = BorderStyle.FixedSingle;
                    picMas[k].SizeMode = PictureBoxSizeMode.StretchImage;


                    
                }
                PA_Files.Enabled = true;
                PA_File.Enabled = true;
                PA_ButtonMassiiv.Enabled = false;


            }



        }
    }
}
