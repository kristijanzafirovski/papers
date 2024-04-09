namespace kolokvezba
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
            this.Allpaperslb = new System.Windows.Forms.ListBox();
            this.Authorstb = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Addpaperbtn = new System.Windows.Forms.Button();
            this.Deletepaperbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Allpaperslb
            // 
            this.Allpaperslb.FormattingEnabled = true;
            this.Allpaperslb.Location = new System.Drawing.Point(51, 45);
            this.Allpaperslb.Name = "Allpaperslb";
            this.Allpaperslb.Size = new System.Drawing.Size(237, 290);
            this.Allpaperslb.TabIndex = 0;
            // 
            // Authorstb
            // 
            this.Authorstb.FormattingEnabled = true;
            this.Authorstb.Location = new System.Drawing.Point(500, 45);
            this.Authorstb.Name = "Authorstb";
            this.Authorstb.Size = new System.Drawing.Size(237, 290);
            this.Authorstb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "All papers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Authors and papers";
            // 
            // Addpaperbtn
            // 
            this.Addpaperbtn.Location = new System.Drawing.Point(52, 346);
            this.Addpaperbtn.Name = "Addpaperbtn";
            this.Addpaperbtn.Size = new System.Drawing.Size(235, 32);
            this.Addpaperbtn.TabIndex = 4;
            this.Addpaperbtn.Text = "Add new paper";
            this.Addpaperbtn.UseVisualStyleBackColor = true;
            this.Addpaperbtn.Click += new System.EventHandler(this.Addpaperbtn_Click);
            // 
            // Deletepaperbtn
            // 
            this.Deletepaperbtn.Location = new System.Drawing.Point(52, 384);
            this.Deletepaperbtn.Name = "Deletepaperbtn";
            this.Deletepaperbtn.Size = new System.Drawing.Size(235, 32);
            this.Deletepaperbtn.TabIndex = 5;
            this.Deletepaperbtn.Text = "Delete paper";
            this.Deletepaperbtn.UseVisualStyleBackColor = true;
            this.Deletepaperbtn.Click += new System.EventHandler(this.Deletepaperbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Deletepaperbtn);
            this.Controls.Add(this.Addpaperbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Authorstb);
            this.Controls.Add(this.Allpaperslb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Allpaperslb;
        private System.Windows.Forms.ListBox Authorstb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Addpaperbtn;
        private System.Windows.Forms.Button Deletepaperbtn;
    }
}

