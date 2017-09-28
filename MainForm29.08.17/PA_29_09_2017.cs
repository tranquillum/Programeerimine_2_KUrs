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
    public partial class PA_29_09_2017 : Form
    {

        Random r = new Random();
        int laius, korgus;
        public PA_29_09_2017()
        {
            InitializeComponent();
        }

        private void Juhuarvud()
        {
            int x1 = r.Next(laius);
            int x2 = r.Next(laius);
            int y1 = r.Next(korgus);
            int y2 = r.Next(korgus);

            PA_X1koordinaat.Text = x1.ToString();

        }


        private void PA_Joon_Click(object sender, EventArgs e)
        {
            Juhuarvud();
        }
    }
}
