﻿using System;
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
    public partial class AP_mainform : Form
    {
        
        Form f1 = new PA_29_08_17();
        Form f2 = new PA_07_09_2017();
        Form f3 = new PA_29_09_2017();
        Form f4 = new PA_12_10_2017();
        Form f5 = new _26_10_2017_Trigonom();
        Form f6 = new PA_09_11_17_File();
        Form f7 = new PA_26_10_17_filebrowser();
        Form f8 = new PA_30_11_17_Puzzle();
        public AP_mainform()
        {
            InitializeComponent();
        }

        private void PA_button1_Click(object sender, EventArgs e)
        {
            if (f1.Visible == false) // проверка: видна ли форма / если нет то показать
            {
                f1 = new PA_29_08_17();
            }
            f1.Visible = true;
            f1.Activate();
        }

        private void PA_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (f2.Visible == false) // проверка: видна ли форма / если нет то показать
            {
                f2 = new PA_07_09_2017();
            }
            f2.Visible = true;
            f2.Activate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (f3.Visible == false) // проверка: видна ли форма / если нет то показать
            {
                f3 = new PA_29_09_2017();
            }
            f3.Visible = true;
            f3.Activate();
        }

        private void PA_12_10_2017_Click(object sender, EventArgs e)
        {
            if (f4.Visible == false) // проверка: видна ли форма / если нет то показать
            {
                f4 = new PA_12_10_2017();
            }
            f4.Visible = true;
            f4.Activate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (f5.Visible == false) // проверка: видна ли форма / если нет то показать
            {
                f5 = new _26_10_2017_Trigonom();
            }
            f5.Visible = true;
            f5.Activate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (f6.Visible == false) // проверка: видна ли форма / если нет то показать
            {
                f6 = new PA_09_11_17_File();
            }
            f6.Visible = true;
            f6.Activate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (f7.Visible == false) // проверка: видна ли форма / если нет то показать
            {
                f7 = new PA_26_10_17_filebrowser();
            }
            f7.Visible = true;
            f7.Activate();
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            if (f8.Visible == false) // проверка: видна ли форма / если нет то показать
            {
                f8 = new PA_30_11_17_Puzzle();
            }
            f8.Visible = true;
            f8.Activate();
        }
    }
    
}
