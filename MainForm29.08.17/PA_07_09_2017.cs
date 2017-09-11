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

        private void PA_Numbrit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                btnNum[i] = new Button();
                PA_groupBox.Controls.Add(btnNum[i]);
                btnNum[i].Width = 100;
                btnNum[i].Height = 100;
                btnNum[i].Top = 100;
                btnNum[i].Left = 110*i+10;
                btnNum[i].Text = i.ToString();
                btnNum[i].BackColor = Color.AliceBlue;
               //Test
            }
        }
    }
}
