﻿namespace MainForm29._08._17
{
    partial class AP_mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AP_mainform));
            this.PA_button1 = new System.Windows.Forms.Button();
            this.PA_Exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PA_button1
            // 
            this.PA_button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PA_button1.Location = new System.Drawing.Point(14, 13);
            this.PA_button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PA_button1.Name = "PA_button1";
            this.PA_button1.Size = new System.Drawing.Size(279, 58);
            this.PA_button1.TabIndex = 0;
            this.PA_button1.Text = "29.08.2017\r\nCalculator";
            this.PA_button1.UseVisualStyleBackColor = false;
            this.PA_button1.Click += new System.EventHandler(this.PA_button1_Click);
            // 
            // PA_Exit
            // 
            this.PA_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PA_Exit.Location = new System.Drawing.Point(14, 448);
            this.PA_Exit.Name = "PA_Exit";
            this.PA_Exit.Size = new System.Drawing.Size(279, 49);
            this.PA_Exit.TabIndex = 2;
            this.PA_Exit.Text = "EXIT";
            this.PA_Exit.UseVisualStyleBackColor = false;
            this.PA_Exit.Click += new System.EventHandler(this.PA_Exit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(14, 79);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(279, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "07.09.2017";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AP_mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(307, 509);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PA_Exit);
            this.Controls.Add(this.PA_button1);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AP_mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PA_button1;
        private System.Windows.Forms.Button PA_Exit;
        private System.Windows.Forms.Button button1;
    }
}

