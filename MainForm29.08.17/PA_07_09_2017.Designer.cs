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
            this.SuspendLayout();
            // 
            // PA_groupBox
            // 
            this.PA_groupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PA_groupBox.Location = new System.Drawing.Point(-2, 28);
            this.PA_groupBox.Name = "PA_groupBox";
            this.PA_groupBox.Size = new System.Drawing.Size(309, 483);
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
            // PA_07_09_2017
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 509);
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
    }
}