namespace MainForm29._08._17
{
    partial class PA_26_10_17_filebrowser
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
            this.PA_FileBox = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.PA_ButtonMassiiv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PA_FileBox
            // 
            this.PA_FileBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PA_FileBox.Location = new System.Drawing.Point(296, 48);
            this.PA_FileBox.Name = "PA_FileBox";
            this.PA_FileBox.Size = new System.Drawing.Size(699, 604);
            this.PA_FileBox.TabIndex = 0;
            this.PA_FileBox.TabStop = false;
            // 
            // PA_ButtonMassiiv
            // 
            this.PA_ButtonMassiiv.Location = new System.Drawing.Point(12, 48);
            this.PA_ButtonMassiiv.Name = "PA_ButtonMassiiv";
            this.PA_ButtonMassiiv.Size = new System.Drawing.Size(211, 56);
            this.PA_ButtonMassiiv.TabIndex = 1;
            this.PA_ButtonMassiiv.Text = "Massiiv";
            this.PA_ButtonMassiiv.UseVisualStyleBackColor = true;
            this.PA_ButtonMassiiv.Click += new System.EventHandler(this.PA_ButtonMassiiv_Click);
            // 
            // PA_26_10_17_filebrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1381, 777);
            this.Controls.Add(this.PA_ButtonMassiiv);
            this.Controls.Add(this.PA_FileBox);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "PA_26_10_17_filebrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filebrowser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PA_FileBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button PA_ButtonMassiiv;
    }
}