namespace MainForm29._08._17
{
    partial class PA_07_09_2017
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
            this.PA_groupBox = new System.Windows.Forms.GroupBox();
            this.PA_Numbrit = new System.Windows.Forms.Button();
            this.Numbrit2 = new System.Windows.Forms.Button();
            this.PA_Ekraan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PA_groupBox
            // 
            this.PA_groupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PA_groupBox.Location = new System.Drawing.Point(-2, 214);
            this.PA_groupBox.Name = "PA_groupBox";
            this.PA_groupBox.Size = new System.Drawing.Size(309, 453);
            this.PA_groupBox.TabIndex = 0;
            this.PA_groupBox.TabStop = false;
            // 
            // PA_Numbrit
            // 
            this.PA_Numbrit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.PA_Numbrit.Location = new System.Drawing.Point(-2, -2);
            this.PA_Numbrit.Name = "PA_Numbrit";
            this.PA_Numbrit.Size = new System.Drawing.Size(87, 32);
            this.PA_Numbrit.TabIndex = 0;
            this.PA_Numbrit.Text = "Numbrit";
            this.PA_Numbrit.UseVisualStyleBackColor = false;
            this.PA_Numbrit.Click += new System.EventHandler(this.PA_Numbrit_Click);
            // 
            // Numbrit2
            // 
            this.Numbrit2.Location = new System.Drawing.Point(97, 1);
            this.Numbrit2.Name = "Numbrit2";
            this.Numbrit2.Size = new System.Drawing.Size(88, 27);
            this.Numbrit2.TabIndex = 1;
            this.Numbrit2.Text = "numbrit2";
            this.Numbrit2.UseVisualStyleBackColor = true;
            this.Numbrit2.Click += new System.EventHandler(this.Numbrit2_Click);
            // 
            // PA_Ekraan
            // 
            this.PA_Ekraan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PA_Ekraan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PA_Ekraan.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.PA_Ekraan.Location = new System.Drawing.Point(17, 87);
            this.PA_Ekraan.Name = "PA_Ekraan";
            this.PA_Ekraan.Size = new System.Drawing.Size(279, 65);
            this.PA_Ekraan.TabIndex = 2;
            this.PA_Ekraan.Text = "0";
            this.PA_Ekraan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PA_07_09_2017
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 671);
            this.Controls.Add(this.PA_Ekraan);
            this.Controls.Add(this.Numbrit2);
            this.Controls.Add(this.PA_Numbrit);
            this.Controls.Add(this.PA_groupBox);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "PA_07_09_2017";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PA_07_09_2017";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PA_groupBox;
        private System.Windows.Forms.Button PA_Numbrit;
        private System.Windows.Forms.Button Numbrit2;
        private System.Windows.Forms.Label PA_Ekraan;
    }
}