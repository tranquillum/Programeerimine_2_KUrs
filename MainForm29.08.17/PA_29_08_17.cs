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
    public partial class PA_29_08_17 : Form
    {

        double arv1 ;
        double arv2 ;
        string tehe = "";


        public PA_29_08_17()
        {
            InitializeComponent();
        }

        private void PA_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
          
        }

        private void button11_Click(object sender, EventArgs e)
        {

            if (PA_Arv.Text == "0")
            {
                
                PA_Arv.Text = "";
                PA_Arv.Text += "0";
            }
            else PA_Arv.Text += "0";
        }

        private void PA_button1_Click(object sender, EventArgs e)
        {

            if (PA_Arv.Text == "0")
            {
                PA_Arv.Text = "";
                PA_Arv.Text += "1";
            }
            else PA_Arv.Text += "1";
        }

        private void PA_button2_Click(object sender, EventArgs e)
        {
            if (PA_Arv.Text == "0")
            {
                PA_Arv.Text = "";
                PA_Arv.Text += "2";
            }
            else PA_Arv.Text += "2";
        }

        private void PA_button3_Click(object sender, EventArgs e)
        {
            if (PA_Arv.Text == "0")
            {
                PA_Arv.Text = "";
                PA_Arv.Text += "3";
            }
            else PA_Arv.Text += "3";
        }

        private void PA_button4_Click(object sender, EventArgs e)
        {
            if (PA_Arv.Text == "0")
            {
                PA_Arv.Text = "";
                PA_Arv.Text += "4";
            }
            else PA_Arv.Text += "4";
        }

        private void PA_button5_Click(object sender, EventArgs e)
        {
            if (PA_Arv.Text == "0")
            {
                PA_Arv.Text = "";
                PA_Arv.Text += "5";
            }
            else PA_Arv.Text += "5";
        }

        private void PA_button6_Click(object sender, EventArgs e)
        {
            if (PA_Arv.Text == "0")
            {
                PA_Arv.Text = "";
                PA_Arv.Text += "6";
            }
            else PA_Arv.Text += "6";
        }

        private void PA_button7_Click(object sender, EventArgs e)
        {
            if (PA_Arv.Text == "0")
            {
                PA_Arv.Text = "";
                PA_Arv.Text += "7";
            }
            else PA_Arv.Text += "7";
        }

        private void PA_button8_Click(object sender, EventArgs e)
        {
            if (PA_Arv.Text == "0")
            {
                PA_Arv.Text = "";
                PA_Arv.Text += "8";
            }
            else PA_Arv.Text += "8";
        }

        private void PA_button9_Click(object sender, EventArgs e)
        {
            if (PA_Arv.Text == "0")
            {
                PA_Arv.Text = "";
                PA_Arv.Text += "9";
            }
            else PA_Arv.Text += "9";
        }

        private void PA_buttonKoma_Click(object sender, EventArgs e)
        {
            if (!PA_Arv.Text.Contains(","))
            {
                PA_Arv.Text += ",";
            }
        }

        private void PA_buttonMark_Click(object sender, EventArgs e)
        {
            double arv = Convert.ToDouble(PA_Arv.Text);
            PA_Arv.Text = (-arv).ToString();
        }

        private void PA_buttonKust_Click(object sender, EventArgs e)
        {
            PA_jagmark.ForeColor = System.Drawing.Color.White;
            PA_kordmark.ForeColor = System.Drawing.Color.White;
            PA_lahmark.ForeColor = System.Drawing.Color.White;
            PA_liitmark.ForeColor = System.Drawing.Color.White;
            PA_Arv.Text = "0";
            arv1 = 0;
            arv2 = 0;
            
        }

        private void PA_buttonKust1_Click(object sender, EventArgs e)
        {
            string t = PA_Arv.Text;
            if (PA_Arv.Text == "Viga")
            {
                PA_Arv.Text = "0";

            }
            else
            {
                if (PA_Arv.Text != "")
                {

                    t = PA_Arv.Text.Remove(t.Length - 1, 1);
                    PA_Arv.Text = t;
                }
                if (PA_Arv.Text == "")
                {
                    PA_Arv.Text = "0";
                }
            }
        }

        private void PA_buttonKor_Click(object sender, EventArgs e)
        {
            PA_kordmark.ForeColor = System.Drawing.Color.Black;
            arv1 = Convert.ToDouble(PA_Arv.Text);
            tehe = "*";

            PA_Arv.Text = "0";
        }

       

        private void PA_buttonJag_Click(object sender, EventArgs e)
        {
            PA_jagmark.ForeColor = System.Drawing.Color.Black;
            arv1 = Convert.ToDouble(PA_Arv.Text);
            tehe = "/";
            PA_Arv.Text = "0";
        }

        private void PA_buttonLah_Click(object sender, EventArgs e)
        {
            PA_lahmark.ForeColor = System.Drawing.Color.Black;
            arv1 = Convert.ToDouble(PA_Arv.Text);
            tehe = "-";
            PA_Arv.Text = "0";
        }

        private void PA_buttonLiit_Click(object sender, EventArgs e)
        {
            PA_liitmark.ForeColor = System.Drawing.Color.Black;
            arv1 = Convert.ToDouble(PA_Arv.Text);
            tehe = "+";
            PA_Arv.Text = "0";
        }
        private void PA_buttonVor_Click(object sender, EventArgs e)
        {
            PA_jagmark.ForeColor = System.Drawing.Color.White;
            PA_kordmark.ForeColor = System.Drawing.Color.White;
            PA_lahmark.ForeColor = System.Drawing.Color.White;
            PA_liitmark.ForeColor = System.Drawing.Color.White;
            
            arv2 = Convert.ToDouble(PA_Arv.Text);
            if (tehe == "*")
            {
                arv1 = arv1 * arv2;
                PA_Arv.Text = Convert.ToString(arv1);
                
            }
            if (tehe == "+")
            {
                arv1 = arv1 + arv2;
                PA_Arv.Text = Convert.ToString(arv1);

            }
            if (tehe == "-")
            {
                arv1 = arv1 - arv2;
                PA_Arv.Text = Convert.ToString(arv1);

            }
            if (tehe == "/")
            {
                if (arv2 == 0)
                {
                    PA_Arv.Text = "Viga";
                }
                else
                {
                    arv1 = arv1 / arv2;
                    PA_Arv.Text = Convert.ToString(arv1);
                }

            }
        }
        

        private void PA_29_08_17_Load(object sender, EventArgs e)
        {
            PA_jagmark.ForeColor = System.Drawing.Color.White;
            PA_kordmark.ForeColor = System.Drawing.Color.White;
            PA_lahmark.ForeColor = System.Drawing.Color.White;
            PA_liitmark.ForeColor = System.Drawing.Color.White;
        }
    }
}
