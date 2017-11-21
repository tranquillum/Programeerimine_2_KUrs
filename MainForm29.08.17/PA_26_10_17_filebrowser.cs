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
    public partial class PA_26_10_17_filebrowser : Form
    {

        int kx = 4, ky = 3;
        PictureBox[] picMas;
        public PA_26_10_17_filebrowser()
        {
            InitializeComponent();
        }

        private void PA_ButtonMassiiv_Click(object sender, EventArgs e)
        {
            picMas = new PictureBox[kx * ky];
            int ww = PA_FileBox.Width / kx; //разделить ширину гроупбокса на количество обьектов по горизонтали получить размер одной ячкйки по горизонтали
            int hh = PA_FileBox.Height / ky;// разделить высоту гроупбокаса на количество обьектов по вертикали получить рамер одной ячейки по вертикали

            for (int i = 0; i <= ky; i++)
            {
                for (int y = 0; y < kx; y++)
                {
                    picMas[i] = new PictureBox();
                    PA_FileBox.Controls.Add(picMas[i]);
                    picMas[i].Width = ww;
                    picMas[i].Height = hh;
                    picMas[i].BackColor = Color.Black;
                    picMas[i].Top = hh * i;
                    picMas[i].Left = ww * y;
                    picMas[i].BorderStyle = BorderStyle.FixedSingle;
                }
                

            }



        }
    }
}
