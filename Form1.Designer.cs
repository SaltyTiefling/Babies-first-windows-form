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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblMijnLabel = new System.Windows.Forms.Label();
            this.btnButton1 = new System.Windows.Forms.Button();
            this.cbFirstCombo = new System.Windows.Forms.ComboBox();
            this.lbFirstListBox = new System.Windows.Forms.ListBox();
            this.tbxNewItem = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMijnLabel
            // 
            this.lblMijnLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMijnLabel.AutoSize = true;
            this.lblMijnLabel.Location = new System.Drawing.Point(74, 35);
            this.lblMijnLabel.Name = "lblMijnLabel";
            this.lblMijnLabel.Size = new System.Drawing.Size(50, 13);
            this.lblMijnLabel.TabIndex = 0;
            this.lblMijnLabel.Text = "mijn label";
            this.lblMijnLabel.Click += new System.EventHandler(this.lblMijnLabel_Click);
            // 
            // btnButton1
            // 
            this.btnButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnButton1.Location = new System.Drawing.Point(42, 51);
            this.btnButton1.Name = "btnButton1";
            this.btnButton1.Size = new System.Drawing.Size(141, 24);
            this.btnButton1.TabIndex = 1;
            this.btnButton1.Text = "Klick mij!";
            this.btnButton1.UseVisualStyleBackColor = true;
            this.btnButton1.Click += new System.EventHandler(this.btnButton1_Click);
            // 
            // cbFirstCombo
            // 
            this.cbFirstCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFirstCombo.FormattingEnabled = true;
            this.cbFirstCombo.Location = new System.Drawing.Point(42, 81);
            this.cbFirstCombo.Name = "cbFirstCombo";
            this.cbFirstCombo.Size = new System.Drawing.Size(142, 21);
            this.cbFirstCombo.TabIndex = 2;
            this.cbFirstCombo.SelectedIndexChanged += new System.EventHandler(this.cbFirstCombo_SelectedIndexChanged);
            // 
            // lbFirstListBox
            // 
            this.lbFirstListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFirstListBox.FormattingEnabled = true;
            this.lbFirstListBox.Location = new System.Drawing.Point(42, 109);
            this.lbFirstListBox.Name = "lbFirstListBox";
            this.lbFirstListBox.Size = new System.Drawing.Size(141, 134);
            this.lbFirstListBox.TabIndex = 3;
            // 
            // tbxNewItem
            // 
            this.tbxNewItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxNewItem.Location = new System.Drawing.Point(42, 249);
            this.tbxNewItem.Name = "tbxNewItem";
            this.tbxNewItem.Size = new System.Drawing.Size(141, 20);
            this.tbxNewItem.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(42, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "Toevoegen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 356);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxNewItem);
            this.Controls.Add(this.lbFirstListBox);
            this.Controls.Add(this.cbFirstCombo);
            this.Controls.Add(this.btnButton1);
            this.Controls.Add(this.lblMijnLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMijnLabel;
        private System.Windows.Forms.Button btnButton1;
        private System.Windows.Forms.ComboBox cbFirstCombo;
        private System.Windows.Forms.ListBox lbFirstListBox;
        private System.Windows.Forms.TextBox tbxNewItem;
        private System.Windows.Forms.Button button1;
    }
}

