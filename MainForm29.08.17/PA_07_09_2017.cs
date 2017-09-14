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
        double arv1;
        double arv2;
        string tehe = "";
        public PA_07_09_2017()
        {
            InitializeComponent();
        }

        bool showNumbers = false;
        private void PA_Numbrit_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    btnNum[i] = new Button();
            //    PA_groupBox.Controls.Add(btnNum[i]);
            //    btnNum[i].Width = 100;
            //    btnNum[i].Height = 100;
            //    btnNum[i].Top = 100;
            //    btnNum[i].Left = 110*i+10;
            //    btnNum[i].Text = i.ToString();
            //    btnNum[i].BackColor = Color.AliceBlue;

            //} 







            if (showNumbers)
            {
                showNumbers = false;
                ClearNumbers();
                return;
            }
            else
            {
                showNumbers = true;
                SpawnNumbers();
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
            }
            private void SpawnNumbers()
            {

                int buttonsPerLine = 3;
                int buttonsPerRow = 4;

                int frameWidth = PA_groupBox.Width;
                int frameHeight = PA_groupBox.Height;

                int j = 0;
                double buttonWidht = frameWidth / buttonsPerLine;
                buttonWidht = Math.Floor(buttonWidht);

                double buttonHeight = frameHeight / buttonsPerRow;
                buttonHeight = Math.Floor(buttonHeight);

                int topAmount = frameHeight - Convert.ToInt32(buttonHeight);
                int leftAmount = Convert.ToInt32(buttonWidht);

                double widthAmount = (frameWidth / buttonWidht);
                double heightAmount = (frameHeight / buttonHeight);
                widthAmount = Math.Floor(widthAmount);

                for (int i = 0; i < 12; i++)
                {

                    if (j >= widthAmount)
                    {
                        topAmount -= Convert.ToInt32(buttonHeight);
                        j = 0;
                    }
                    btnNum[i] = new Button()
                    {
                        Width = Convert.ToInt32(buttonWidht),
                        Height = Convert.ToInt32(buttonHeight),
                        Top = topAmount,
                        Left = leftAmount * j,
                        BackColor = Color.DimGray
                    };
                    PA_groupBox.Controls.Add(btnNum[i]);
                    j++;

                }
                for (int i = 0; btnNum.Length > i; i++)
                {
                    if (i >= 3)
                    {
                        btnNum[i].Text = (i - 2).ToString();
                    }
                    btnNum[0].Text = "+/-";
                    btnNum[1].Text = "0";
                    btnNum[2].Text = ",";
                }
            

            }

        private void Numbrit2_Click(object sender, EventArgs e)
        {
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
                btnNum[i].Click += new EventHandler(btnNum_Click);
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


                    //1-9
                }
                btnNum[i].Top = (int)(rn * dy + (rn+1) * dyy);
                btnNum[i].Left = (int)(vn * dx + (vn+1) * dxx);
            }
        }



        private void btnNum_Click(object sender, EventArgs e)
        {
            int bln = Array.IndexOf(btnNum, (Button)sender);

            if (PA_Ekraan.Text == "0")
            PA_Ekraan.Text = "";
            PA_Ekraan.Text += btnNum[bln].Text;

        }

        private void PA_buttonKustALL_Click(object sender, EventArgs e)
        {

            PA_Ekraan.Text = "0";
            arv1 = 0;
            arv2 = 0;
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

        private void PA_Tehed_Click(object sender, EventArgs e)
        {
            float dx = PA_groupBoxTehed.Width / 1F;
            float dxx = dx / 1;
            float dy = PA_groupBoxTehed.Height / 5F;
            float dyy = dy / 5;
            for (int i = 0; i < 5; i++)
            {
                btnTehe[i] = new Button();
                PA_groupBoxTehed.Controls.Add(btnTehe[i]);
                btnTehe[i].Width = (int)dx;
                btnTehe[i].Height = (int)dy;
                btnTehe[i].BackColor = Color.Bisque;
                btnTehe[i].Click += new EventHandler(btnTehe_Click);
                int rn = 3, vn = 0;

                if (i == 0||i>5)
                {


                    if (i == 0)
                    {
                        btnTehe[i].Text = "=";
                        //rn = 0;
                    }
                    else if (i == 1)
                    {
                        btnTehe[i].Text = "+";
                        //rn = 1;
                    }
                    else if (i == 2)
                    {
                        btnTehe[i].Text = "-";
                        //rn = 2;
                    }
                    else if (i == 3)
                    {
                        btnTehe[i].Text = "*";
                        //rn = 3;
                    }
                    else if (i == 4)
                    {
                        btnTehe[i].Text = "/";
                        //rn = 4;
                    }



                }


                btnTehe[i].Top = (int)(rn * dy + (rn + 1) * dyy);
                //btnTehe[i].Left = (int)(vn * dx + (vn + 1) * dxx);
            }
        }

        private void btnTehe_Click(object sender, EventArgs e)
        {
            int bln = Array.IndexOf(btnTehe, (Button)sender);

            
            PA_Ekraan.Text += btnTehe[bln].Text;

        }


    }
}
