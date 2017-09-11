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
    }
}
