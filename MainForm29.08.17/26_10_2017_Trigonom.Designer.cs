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
            this.PA_PictureBox.Click += new System.EventHandler(this.PA_PictureBox_Click);
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
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "-2PI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1207, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "+2PI";
            // 
            // _26_10_2017_Trigonom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1277, 857);
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
    }
}