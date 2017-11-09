namespace MainForm29._08._17
{
    partial class PA_09_11_17_File
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
            this.PA_groupBox1 = new System.Windows.Forms.GroupBox();
            this.PA_FileValik = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PA_IMGBox = new System.Windows.Forms.PictureBox();
            this.PA_Resolution = new System.Windows.Forms.Label();
            this.PA_NormalIMG = new System.Windows.Forms.RadioButton();
            this.PA_StrethIMG = new System.Windows.Forms.RadioButton();
            this.PA_AutoSizeIMG = new System.Windows.Forms.RadioButton();
            this.PA_CentralIMG = new System.Windows.Forms.RadioButton();
            this.PA_ZoomIMG = new System.Windows.Forms.RadioButton();
            this.PA_openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PA_IMGBox2 = new System.Windows.Forms.PictureBox();
            this.PA_groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PA_IMGBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PA_IMGBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PA_groupBox1
            // 
            this.PA_groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PA_groupBox1.Controls.Add(this.PA_IMGBox2);
            this.PA_groupBox1.Controls.Add(this.PA_ZoomIMG);
            this.PA_groupBox1.Controls.Add(this.PA_CentralIMG);
            this.PA_groupBox1.Controls.Add(this.PA_AutoSizeIMG);
            this.PA_groupBox1.Controls.Add(this.PA_StrethIMG);
            this.PA_groupBox1.Controls.Add(this.PA_NormalIMG);
            this.PA_groupBox1.Controls.Add(this.PA_Resolution);
            this.PA_groupBox1.Controls.Add(this.PA_IMGBox);
            this.PA_groupBox1.Controls.Add(this.label1);
            this.PA_groupBox1.Controls.Add(this.PA_FileValik);
            this.PA_groupBox1.Location = new System.Drawing.Point(60, 26);
            this.PA_groupBox1.Name = "PA_groupBox1";
            this.PA_groupBox1.Size = new System.Drawing.Size(864, 602);
            this.PA_groupBox1.TabIndex = 0;
            this.PA_groupBox1.TabStop = false;
            this.PA_groupBox1.Text = "Uksik fail";
            // 
            // PA_FileValik
            // 
            this.PA_FileValik.BackColor = System.Drawing.Color.Maroon;
            this.PA_FileValik.Location = new System.Drawing.Point(45, 40);
            this.PA_FileValik.Name = "PA_FileValik";
            this.PA_FileValik.Size = new System.Drawing.Size(152, 46);
            this.PA_FileValik.TabIndex = 0;
            this.PA_FileValik.Text = "Gaili valik";
            this.PA_FileValik.UseVisualStyleBackColor = false;
            this.PA_FileValik.Click += new System.EventHandler(this.PA_FileValik_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(40, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "SizeMode";
            // 
            // PA_IMGBox
            // 
            this.PA_IMGBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PA_IMGBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.PA_IMGBox.Location = new System.Drawing.Point(220, 25);
            this.PA_IMGBox.Name = "PA_IMGBox";
            this.PA_IMGBox.Size = new System.Drawing.Size(628, 312);
            this.PA_IMGBox.TabIndex = 2;
            this.PA_IMGBox.TabStop = false;
            this.PA_IMGBox.Click += new System.EventHandler(this.PA_IMGBox_Click);
            // 
            // PA_Resolution
            // 
            this.PA_Resolution.AutoSize = true;
            this.PA_Resolution.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.PA_Resolution.ForeColor = System.Drawing.Color.Red;
            this.PA_Resolution.Location = new System.Drawing.Point(270, 488);
            this.PA_Resolution.Name = "PA_Resolution";
            this.PA_Resolution.Size = new System.Drawing.Size(0, 27);
            this.PA_Resolution.TabIndex = 3;
            // 
            // PA_NormalIMG
            // 
            this.PA_NormalIMG.AutoSize = true;
            this.PA_NormalIMG.Checked = true;
            this.PA_NormalIMG.Location = new System.Drawing.Point(45, 128);
            this.PA_NormalIMG.Name = "PA_NormalIMG";
            this.PA_NormalIMG.Size = new System.Drawing.Size(86, 22);
            this.PA_NormalIMG.TabIndex = 4;
            this.PA_NormalIMG.TabStop = true;
            this.PA_NormalIMG.Text = "Normal";
            this.PA_NormalIMG.UseVisualStyleBackColor = true;
            // 
            // PA_StrethIMG
            // 
            this.PA_StrethIMG.AutoSize = true;
            this.PA_StrethIMG.Location = new System.Drawing.Point(45, 156);
            this.PA_StrethIMG.Name = "PA_StrethIMG";
            this.PA_StrethIMG.Size = new System.Drawing.Size(146, 22);
            this.PA_StrethIMG.TabIndex = 5;
            this.PA_StrethIMG.Text = "StretchImage";
            this.PA_StrethIMG.UseVisualStyleBackColor = true;
            // 
            // PA_AutoSizeIMG
            // 
            this.PA_AutoSizeIMG.AutoSize = true;
            this.PA_AutoSizeIMG.Location = new System.Drawing.Point(45, 184);
            this.PA_AutoSizeIMG.Name = "PA_AutoSizeIMG";
            this.PA_AutoSizeIMG.Size = new System.Drawing.Size(106, 22);
            this.PA_AutoSizeIMG.TabIndex = 6;
            this.PA_AutoSizeIMG.Text = "AutoSize";
            this.PA_AutoSizeIMG.UseVisualStyleBackColor = true;
            // 
            // PA_CentralIMG
            // 
            this.PA_CentralIMG.AutoSize = true;
            this.PA_CentralIMG.Location = new System.Drawing.Point(45, 212);
            this.PA_CentralIMG.Name = "PA_CentralIMG";
            this.PA_CentralIMG.Size = new System.Drawing.Size(136, 22);
            this.PA_CentralIMG.TabIndex = 7;
            this.PA_CentralIMG.Text = "CenterImage";
            this.PA_CentralIMG.UseVisualStyleBackColor = true;
            // 
            // PA_ZoomIMG
            // 
            this.PA_ZoomIMG.AutoSize = true;
            this.PA_ZoomIMG.Location = new System.Drawing.Point(45, 240);
            this.PA_ZoomIMG.Name = "PA_ZoomIMG";
            this.PA_ZoomIMG.Size = new System.Drawing.Size(66, 22);
            this.PA_ZoomIMG.TabIndex = 8;
            this.PA_ZoomIMG.Text = "Zoom";
            this.PA_ZoomIMG.UseVisualStyleBackColor = true;
            // 
            // PA_openFileDialog1
            // 
            this.PA_openFileDialog1.FileName = "PA_openFileDialog1";
            // 
            // PA_IMGBox2
            // 
            this.PA_IMGBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PA_IMGBox2.Location = new System.Drawing.Point(220, 343);
            this.PA_IMGBox2.Name = "PA_IMGBox2";
            this.PA_IMGBox2.Size = new System.Drawing.Size(628, 245);
            this.PA_IMGBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PA_IMGBox2.TabIndex = 9;
            this.PA_IMGBox2.TabStop = false;
            // 
            // PA_09_11_17_File
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(965, 661);
            this.Controls.Add(this.PA_groupBox1);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "PA_09_11_17_File";
            this.Text = "PA_09_11_17_File";
            this.Load += new System.EventHandler(this.PA_09_11_17_File_Load);
            this.PA_groupBox1.ResumeLayout(false);
            this.PA_groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PA_IMGBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PA_IMGBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PA_groupBox1;
        private System.Windows.Forms.RadioButton PA_ZoomIMG;
        private System.Windows.Forms.RadioButton PA_CentralIMG;
        private System.Windows.Forms.RadioButton PA_AutoSizeIMG;
        private System.Windows.Forms.RadioButton PA_StrethIMG;
        private System.Windows.Forms.RadioButton PA_NormalIMG;
        private System.Windows.Forms.Label PA_Resolution;
        private System.Windows.Forms.PictureBox PA_IMGBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PA_FileValik;
        private System.Windows.Forms.OpenFileDialog PA_openFileDialog1;
        private System.Windows.Forms.PictureBox PA_IMGBox2;
    }
}