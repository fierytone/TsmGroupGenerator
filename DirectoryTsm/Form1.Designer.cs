namespace DirectoryTsm
{
    partial class DirectoryTsm
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
            this.inputPath = new System.Windows.Forms.TextBox();
            this.browserTrigger = new System.Windows.Forms.Button();
            this.ScanBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputPath
            // 
            this.inputPath.Location = new System.Drawing.Point(12, 12);
            this.inputPath.Name = "inputPath";
            this.inputPath.ReadOnly = true;
            this.inputPath.Size = new System.Drawing.Size(179, 20);
            this.inputPath.TabIndex = 0;
            // 
            // browserTrigger
            // 
            this.browserTrigger.Location = new System.Drawing.Point(197, 12);
            this.browserTrigger.Name = "browserTrigger";
            this.browserTrigger.Size = new System.Drawing.Size(29, 21);
            this.browserTrigger.TabIndex = 1;
            this.browserTrigger.Text = "...";
            this.browserTrigger.UseVisualStyleBackColor = true;
            this.browserTrigger.Click += new System.EventHandler(this.button1_Click);
            // 
            // ScanBtn
            // 
            this.ScanBtn.Location = new System.Drawing.Point(151, 38);
            this.ScanBtn.Name = "ScanBtn";
            this.ScanBtn.Size = new System.Drawing.Size(75, 23);
            this.ScanBtn.TabIndex = 2;
            this.ScanBtn.Text = "Vælg";
            this.ScanBtn.UseVisualStyleBackColor = true;
            this.ScanBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DirectoryTsm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 71);
            this.Controls.Add(this.ScanBtn);
            this.Controls.Add(this.browserTrigger);
            this.Controls.Add(this.inputPath);
            this.Name = "DirectoryTsm";
            this.Text = "TGG";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputPath;
        private System.Windows.Forms.Button browserTrigger;
        private System.Windows.Forms.Button ScanBtn;
    }
}

