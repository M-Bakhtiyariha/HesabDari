namespace HesabDari.App
{
    partial class frmBackUp
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
            this.btnBackUp = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBackUp
            // 
            this.btnBackUp.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBackUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnBackUp.Location = new System.Drawing.Point(159, 12);
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.Size = new System.Drawing.Size(141, 53);
            this.btnBackUp.TabIndex = 0;
            this.btnBackUp.Text = "پشتیبان گیری";
            this.btnBackUp.UseVisualStyleBackColor = false;
            this.btnBackUp.Click += new System.EventHandler(this.btnBackUp_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnRestore.Location = new System.Drawing.Point(12, 12);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(141, 53);
            this.btnRestore.TabIndex = 0;
            this.btnRestore.Text = "فراخوانی";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // frmBackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(312, 84);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnBackUp);
            this.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Name = "frmBackUp";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "پشتیبان گیری";
            this.Load += new System.EventHandler(this.frmBackUp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackUp;
        private System.Windows.Forms.Button btnRestore;
    }
}