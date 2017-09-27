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
    public partial class PA_07_09_2017 : Form
    {
        Button[] btnNum = new Button[12];
        Button[] btnTehe = new Button[5];
        Button[] btnMem = new Button[6];
        byte TeheNumber = 0;
        byte EelmineTeheNumber = 5;
        string TeheMark = "=";
        double tulemus = 0;
        
        double M ;
        Boolean uus = true;

        public PA_07_09_2017()
        {
            InitializeComponent();
            PA_buttonKustALL.Visible = false;
            PA_buttonKust1.Visible = false;
            PA_Ekraan.Text = "";
        }

        bool showNumbers = false;
        private void PA_Numbrit_Click(object sender, EventArgs e)
        {
            if (showNumbers)
            {
                showNumbers = false;
                ClearNumbers();
                PA_buttonKustALL.Visible = false;
                PA_buttonKust1.Visible = false;
                PA_Ekraan.Text = "";
                return;
            }
            else
            {
                showNumbers = true;
                SpawnNumbers();
                PA_buttonKustALL.Visible = true;
                PA_buttonKust1.Visible = true;
                PA_Ekraan.Text = "0";
            }
        }

        private void PA_groupBox_ResizeEnd(object sender, EventArgs e)
        {
            if (showNumbers)
            {
                ClearNumbers();
                SpawnNumbers();
            }


        }

        private void ClearNumbers()
        {
            for (int i = 0; i < btnNum.Length; i++)
            {
                PA_groupBox.Controls.Clear();
            }


            for (int i = 0; i < btnTehe.Length; i++)
            {
                PA_groupBoxTehed.Controls.Clear();
            }
            for (int i = 0; i < btnMem.Length; i++)
            {
                PA_groupBoxMem.Controls.Clear();
            }
        }



        private void SpawnNumbers()
        {
            //numbrit
            float dx = PA_groupBox.Width / 4F;
            float dxx = dx / 4;
            float dy = PA_groupBox.Height / 5F;
            float dyy = dy / 5;
            for (int i = 0; i < 12; i++)
            {
                btnNum[i] = new Button();
                PA_groupBox.Controls.Add(btnNum[i]);
                btnNum[i].Width = (int)dx;
                btnNum[i].Height = (int)dy;
                btnNum[i].BackColor = Color.Bisque;
                btnNum[i].Click += new EventHandler(BtnNum_Click);
                int rn = 3, vn = 0;
                if (i == 0 || i > 9)
                {
                    if (i == 0)
                    {
                        btnNum[i].Text = "0";
                        vn = 1;
                    }
                    else if (i == 10)
                    {
                        btnNum[i].Text = "+/-";
                        vn = 0;
                    }
                    else
                    {
                        btnNum[i].Text = ",";
                        vn = 2;
                    }
                }
                else
                {
                    btnNum[i].Text = i.ToString();
                    rn = (9 - i) / 3;
                    vn = (i - 1) % 3;
                }
                btnNum[i].Top = (int)(rn * dy + (rn + 1) * dyy);
                btnNum[i].Left = (int)(vn * dx + (vn + 1) * dxx);
            }
            //tehed

            int ix1 = PA_groupBoxTehed.Width * 2 / 3;
            int ix2 = ix1 / 4;
            int iy1 = PA_groupBoxTehed.Height / 6;
            int iy2 = iy1 / 6;
            int ix = ix2;
            int iy = 4 * iy1 + 5 * iy2;
            for (int i = 0; i < 5; i++)
            {
                btnTehe[i] = new Button();
                PA_groupBoxTehed.Controls.Add(btnTehe[i]);
                btnTehe[i].Left = ix;
                btnTehe[i].Width = ix1;
                btnTehe[i].Top = iy;
                btnTehe[i].Height = iy1;
                btnTehe[i].BackColor = Color.LightSkyBlue;
                btnTehe[i].Click += new EventHandler(BtnTehe_Click);
                iy = iy - iy1 - iy2;
            }
            btnTehe[0].Text = "=";
            btnTehe[1].Text = "+";
            btnTehe[2].Text = "-";
            btnTehe[3].Text = "x";
            btnTehe[4].Text = ":";


            //memory

            int ix1m = PA_groupBoxMem.Width / 7;
            int ix2m = ix1 / 5;
            int iy1m = PA_groupBoxMem.Height * 2 / 3;
            int iy2m = iy1 / 4;
            int ixm = 5 * ix1m + 5 * ix2m;  //ix2;
            int iym = iy2;      //4 * iy1m + 5 * iy2m;
            for (int i = 0; i < 6; i++)
            {
                btnMem[i] = new Button();
                PA_groupBoxMem.Controls.Add(btnMem[i]);
                btnMem[i].Left = ixm;
                btnMem[i].Width = ix1m;
                btnMem[i].Top = iym;
                btnMem[i].Height = iy1m;
                btnMem[i].BackColor = Color.LightSkyBlue;
                btnMem[i].Click += new EventHandler(BtnMem_Click);
                ixm = ixm - ix1m - ix2m;   //iym - iy1m - iy2m;
            }
            btnMem[0].Text = "Mˇ";
            btnMem[1].Text = "MS";
            btnMem[2].Text = "M-";
            btnMem[3].Text = "M+";
            btnMem[4].Text = "MR";
            btnMem[5].Text = "MC";




        }
        private void BtnMem_Click(object sender, EventArgs e)
        {

            int bln = Array.IndexOf(btnMem, (Button)sender);
            double arv2 = Convert.ToDouble(PA_Ekraan.Text);
            if (btnMem[bln].Text == "M+") M += arv2;
            else if (btnMem[bln].Text == "M-") M -= arv2;
            else if (btnMem[bln].Text == "MC") M = 0;
           // else if (btnMem[bln].Text == "MS") M = 0;
            else if (btnMem[bln].Text == "MR")PA_Ekraan.Text = M.ToString();
            else if (btnMem[bln].Text == "Mˇ") mem.Text = M.ToString();


            mem.Text = M.ToString();

        }




        private void BtnTehe_Click(object sender, EventArgs e)
        {
            PA_Text.Text += PA_Ekraan.Text;

            double arv = Convert.ToDouble(PA_Ekraan.Text);
            if (TeheNumber == 4) tulemus /= arv;
            else if (TeheNumber == 3) tulemus *= arv;
            else if (TeheNumber == 2) tulemus -= arv;
            else tulemus += arv;
            PA_Ekraan.Text = tulemus.ToString();
            TeheNumber = (byte)(Array.IndexOf(btnTehe, (Button)sender));
            TeheMark = btnTehe[TeheNumber].Text;
            if (TeheNumber > 2 && EelmineTeheNumber < 3)
                PA_Text.Text = "(" + PA_Text.Text + ")";
            PA_Text.Text += (" " + TeheMark + " ");
            if (TeheMark == "=") PA_Text.Text += PA_Ekraan.Text;
            EelmineTeheNumber = TeheNumber;
            uus = true;
        }

        private void BtnNum_Click(object sender, EventArgs e)
        {
            if (uus) PA_Ekraan.Text = "";
            int bln = Array.IndexOf(btnNum, (Button)sender);
            if (btnNum[bln].Text != "+/-" && btnNum[bln].Text != ",")
            {
                if (PA_Ekraan.Text == "0")
                    PA_Ekraan.Text = "";
                PA_Ekraan.Text += btnNum[bln].Text;
            }
             if (btnNum[bln].Text == "," && !PA_Ekraan.Text.Contains (","))
             {
                
                    PA_Ekraan.Text += ",";
                
             }
             if (btnNum[bln].Text == "+/-")
             {
                double arv = Convert.ToDouble(PA_Ekraan.Text);
                PA_Ekraan.Text = (-arv).ToString();
             }
            uus = false;
        }

      
        private void PA_buttonKustALL_Click(object sender, EventArgs e)
        {
            PA_Text.Text = "";
            PA_Ekraan.Text = "0";
            
            tulemus = 0;
        }

        private void PA_buttonKust1_Click(object sender, EventArgs e)
        {
            string t = PA_Ekraan.Text;
            if (PA_Ekraan.Text == "Viga")
            {
                PA_Ekraan.Text = "0";

            }
            else
            {
                if (PA_Ekraan.Text != "")
                {

                    t = PA_Ekraan.Text.Remove(t.Length - 1, 1);
                    PA_Ekraan.Text = t;
                }
                if (PA_Ekraan.Text == "")
                {
                    PA_Ekraan.Text = "0";
                }
            }
        } 
    }
}
