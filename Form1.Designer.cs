namespace Babies_first_windows_form
{
    partial class Form1
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
            this.lblMijnLabel = new System.Windows.Forms.Label();
            this.btnButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMijnLabel
            // 
            this.lblMijnLabel.AutoSize = true;
            this.lblMijnLabel.Location = new System.Drawing.Point(39, 35);
            this.lblMijnLabel.Name = "lblMijnLabel";
            this.lblMijnLabel.Size = new System.Drawing.Size(50, 13);
            this.lblMijnLabel.TabIndex = 0;
            this.lblMijnLabel.Text = "mijn label";
            this.lblMijnLabel.Click += new System.EventHandler(this.lblMijnLabel_Click);
            // 
            // btnButton1
            // 
            this.btnButton1.Location = new System.Drawing.Point(42, 51);
            this.btnButton1.Name = "btnButton1";
            this.btnButton1.Size = new System.Drawing.Size(75, 23);
            this.btnButton1.TabIndex = 1;
            this.btnButton1.Text = "Klick mij!";
            this.btnButton1.UseVisualStyleBackColor = true;
            this.btnButton1.Click += new System.EventHandler(this.btnButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnButton1);
            this.Controls.Add(this.lblMijnLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMijnLabel;
        private System.Windows.Forms.Button btnButton1;
    }
}

