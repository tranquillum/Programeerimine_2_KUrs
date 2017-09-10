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
    public partial class AP_mainform : Form
    {
        
        Form f1 = new PA_29_08_17();
        Form f2 = new PA_07_09_2017();

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
    }
}
