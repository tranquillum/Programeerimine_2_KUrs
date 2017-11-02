namespace MainForm29._08._17
{
    partial class _26_10_2017_Trigonom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PA_PictureBox = new System.Windows.Forms.PictureBox();
            this.PA_Teljed = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PA_SinArv = new System.Windows.Forms.TextBox();
            this.PA_TgArv = new System.Windows.Forms.TextBox();
            this.PA_CosArv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PA_CosM = new System.Windows.Forms.Label();
            this.PA_SinM = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PA_TgM = new System.Windows.Forms.Label();
            this.PA_CtgM = new System.Windows.Forms.Label();
            this.PA_CTgArv = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.PA_Graafik = new System.Windows.Forms.Button();
            this.PA_Clean = new System.Windows.Forms.Button();
            this.PA_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PA_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PA_PictureBox
            // 
            this.PA_PictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.PA_PictureBox.Location = new System.Drawing.Point(74, 115);
            this.PA_PictureBox.Name = "PA_PictureBox";
            this.PA_PictureBox.Size = new System.Drawing.Size(1138, 561);
            this.PA_PictureBox.TabIndex = 15;
            this.PA_PictureBox.TabStop = false;
            // 
            // PA_Teljed
            // 
            this.PA_Teljed.BackColor = System.Drawing.SystemColors.Window;
            this.PA_Teljed.Location = new System.Drawing.Point(12, 12);
            this.PA_Teljed.Name = "PA_Teljed";
            this.PA_Teljed.Size = new System.Drawing.Size(112, 43);
            this.PA_Teljed.TabIndex = 16;
            this.PA_Teljed.Text = "Teljed";
            this.PA_Teljed.UseVisualStyleBackColor = false;
            this.PA_Teljed.Click += new System.EventHandler(this.PA_Teljed_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "-2PI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1207, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "+2PI";
            // 
            // PA_SinArv
            // 
            this.PA_SinArv.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.PA_SinArv.Location = new System.Drawing.Point(386, 69);
            this.PA_SinArv.Multiline = true;
            this.PA_SinArv.Name = "PA_SinArv";
            this.PA_SinArv.Size = new System.Drawing.Size(46, 31);
            this.PA_SinArv.TabIndex = 19;
            this.PA_SinArv.Text = "0";
            this.PA_SinArv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PA_TgArv
            // 
            this.PA_TgArv.Location = new System.Drawing.Point(728, 69);
            this.PA_TgArv.Multiline = true;
            this.PA_TgArv.Name = "PA_TgArv";
            this.PA_TgArv.Size = new System.Drawing.Size(46, 31);
            this.PA_TgArv.TabIndex = 20;
            this.PA_TgArv.Text = "2";
            this.PA_TgArv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PA_CosArv
            // 
            this.PA_CosArv.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.PA_CosArv.Location = new System.Drawing.Point(560, 69);
            this.PA_CosArv.Multiline = true;
            this.PA_CosArv.Name = "PA_CosArv";
            this.PA_CosArv.Size = new System.Drawing.Size(46, 31);
            this.PA_CosArv.TabIndex = 21;
            this.PA_CosArv.Text = "0";
            this.PA_CosArv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Azure;
            this.label3.Location = new System.Drawing.Point(262, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 31);
            this.label3.TabIndex = 22;
            this.label3.Text = "Y=";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Azure;
            this.label4.Location = new System.Drawing.Point(612, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 31);
            this.label4.TabIndex = 23;
            this.label4.Text = "CosX";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PA_CosM
            // 
            this.PA_CosM.BackColor = System.Drawing.Color.Azure;
            this.PA_CosM.Location = new System.Drawing.Point(510, 69);
            this.PA_CosM.Name = "PA_CosM";
            this.PA_CosM.Size = new System.Drawing.Size(44, 31);
            this.PA_CosM.TabIndex = 24;
            this.PA_CosM.Text = "-";
            this.PA_CosM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PA_CosM.Click += new System.EventHandler(this.PA_CosM_Click);
            // 
            // PA_SinM
            // 
            this.PA_SinM.BackColor = System.Drawing.Color.Azure;
            this.PA_SinM.Location = new System.Drawing.Point(334, 69);
            this.PA_SinM.Name = "PA_SinM";
            this.PA_SinM.Size = new System.Drawing.Size(46, 31);
            this.PA_SinM.TabIndex = 25;
            this.PA_SinM.Text = "-";
            this.PA_SinM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PA_SinM.Click += new System.EventHandler(this.PA_SinM_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Azure;
            this.label7.Location = new System.Drawing.Point(780, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 31);
            this.label7.TabIndex = 26;
            this.label7.Text = "TgX";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Azure;
            this.label8.Location = new System.Drawing.Point(438, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 31);
            this.label8.TabIndex = 27;
            this.label8.Text = "SinX";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PA_TgM
            // 
            this.PA_TgM.BackColor = System.Drawing.Color.Azure;
            this.PA_TgM.Location = new System.Drawing.Point(684, 69);
            this.PA_TgM.Name = "PA_TgM";
            this.PA_TgM.Size = new System.Drawing.Size(38, 31);
            this.PA_TgM.TabIndex = 28;
            this.PA_TgM.Text = "-";
            this.PA_TgM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PA_TgM.Click += new System.EventHandler(this.PA_TgM_Click);
            // 
            // PA_CtgM
            // 
            this.PA_CtgM.BackColor = System.Drawing.Color.Azure;
            this.PA_CtgM.Location = new System.Drawing.Point(852, 69);
            this.PA_CtgM.Name = "PA_CtgM";
            this.PA_CtgM.Size = new System.Drawing.Size(40, 31);
            this.PA_CtgM.TabIndex = 29;
            this.PA_CtgM.Text = "-";
            this.PA_CtgM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PA_CtgM.Click += new System.EventHandler(this.PA_CtgM_Click);
            // 
            // PA_CTgArv
            // 
            this.PA_CTgArv.Location = new System.Drawing.Point(898, 69);
            this.PA_CTgArv.Multiline = true;
            this.PA_CTgArv.Name = "PA_CTgArv";
            this.PA_CTgArv.Size = new System.Drawing.Size(46, 31);
            this.PA_CTgArv.TabIndex = 30;
            this.PA_CTgArv.Text = "0";
            this.PA_CTgArv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Azure;
            this.label11.Location = new System.Drawing.Point(950, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 31);
            this.label11.TabIndex = 31;
            this.label11.Text = "CTgX";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PA_Graafik
            // 
            this.PA_Graafik.Location = new System.Drawing.Point(141, 12);
            this.PA_Graafik.Name = "PA_Graafik";
            this.PA_Graafik.Size = new System.Drawing.Size(96, 42);
            this.PA_Graafik.TabIndex = 32;
            this.PA_Graafik.Text = "Graafik";
            this.PA_Graafik.UseVisualStyleBackColor = true;
            this.PA_Graafik.Click += new System.EventHandler(this.PA_Graafik_Click);
            // 
            // PA_Clean
            // 
            this.PA_Clean.Location = new System.Drawing.Point(243, 12);
            this.PA_Clean.Name = "PA_Clean";
            this.PA_Clean.Size = new System.Drawing.Size(96, 42);
            this.PA_Clean.TabIndex = 33;
            this.PA_Clean.Text = "Clean";
            this.PA_Clean.UseVisualStyleBackColor = true;
            this.PA_Clean.Click += new System.EventHandler(this.PA_Clean_Click);
            // 
            // PA_Save
            // 
            this.PA_Save.Location = new System.Drawing.Point(1159, 13);
            this.PA_Save.Name = "PA_Save";
            this.PA_Save.Size = new System.Drawing.Size(96, 42);
            this.PA_Save.TabIndex = 34;
            this.PA_Save.Text = "Save";
            this.PA_Save.UseVisualStyleBackColor = true;
            this.PA_Save.Click += new System.EventHandler(this.PA_Save_Click);
            // 
            // _26_10_2017_Trigonom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1277, 857);
            this.Controls.Add(this.PA_Save);
            this.Controls.Add(this.PA_Clean);
            this.Controls.Add(this.PA_Graafik);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.PA_CTgArv);
            this.Controls.Add(this.PA_CtgM);
            this.Controls.Add(this.PA_TgM);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PA_SinM);
            this.Controls.Add(this.PA_CosM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PA_CosArv);
            this.Controls.Add(this.PA_TgArv);
            this.Controls.Add(this.PA_SinArv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PA_Teljed);
            this.Controls.Add(this.PA_PictureBox);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "_26_10_2017_Trigonom";
            this.Text = "_26_10_2017_Trigonom";
            this.Load += new System.EventHandler(this._26_10_2017_Trigonom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PA_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PA_PictureBox;
        private System.Windows.Forms.Button PA_Teljed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PA_SinArv;
        private System.Windows.Forms.TextBox PA_TgArv;
        private System.Windows.Forms.TextBox PA_CosArv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PA_CosM;
        private System.Windows.Forms.Label PA_SinM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label PA_TgM;
        private System.Windows.Forms.Label PA_CtgM;
        private System.Windows.Forms.TextBox PA_CTgArv;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button PA_Graafik;
        private System.Windows.Forms.Button PA_Clean;
        private System.Windows.Forms.Button PA_Save;
    }
}