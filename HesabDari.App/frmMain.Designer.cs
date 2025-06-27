namespace HesabDari.App
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolS00 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnManagmentOfUserAndPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBackUp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnPersons = new System.Windows.Forms.ToolStripButton();
            this.btnTransaction = new System.Windows.Forms.ToolStripButton();
            this.btnEditDebtor = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblDebt = new System.Windows.Forms.Label();
            this.lblCredite = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbIndebtedness = new System.Windows.Forms.GroupBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grbCreditor = new System.Windows.Forms.GroupBox();
            this.lblminAmount = new System.Windows.Forms.Label();
            this.lblMinName = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbIndebtedness.SuspendLayout();
            this.grbCreditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolS00,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolS00
            // 
            this.toolS00.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolS00.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnManagmentOfUserAndPassword,
            this.btnBackUp});
            this.toolS00.Font = new System.Drawing.Font("Tahoma", 8F);
            this.toolS00.Image = ((System.Drawing.Image)(resources.GetObject("toolS00.Image")));
            this.toolS00.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolS00.Name = "toolS00";
            this.toolS00.Size = new System.Drawing.Size(61, 22);
            this.toolS00.Text = "تنظیمات ";
            // 
            // btnManagmentOfUserAndPassword
            // 
            this.btnManagmentOfUserAndPassword.Name = "btnManagmentOfUserAndPassword";
            this.btnManagmentOfUserAndPassword.Size = new System.Drawing.Size(138, 22);
            this.btnManagmentOfUserAndPassword.Text = "مدیریت ورود";
            this.btnManagmentOfUserAndPassword.Click += new System.EventHandler(this.btnManagmentOfUserAndPassword_Click);
            // 
            // btnBackUp
            // 
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.Size = new System.Drawing.Size(138, 22);
            this.btnBackUp.Text = "پشتیبان گیری";
            this.btnBackUp.Click += new System.EventHandler(this.btnBackUp_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(419, 22);
            this.toolStripLabel1.Text = "به حساب خود برسید قبل از آنکه به حساب شما رسیدگی شود       امام علی علیه السلام";
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPersons,
            this.btnTransaction,
            this.btnEditDebtor,
            this.toolStripButton1,
            this.btnRefresh});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(784, 70);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnPersons
            // 
            this.btnPersons.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btnPersons.Image = ((System.Drawing.Image)(resources.GetObject("btnPersons.Image")));
            this.btnPersons.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPersons.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPersons.Name = "btnPersons";
            this.btnPersons.Size = new System.Drawing.Size(67, 67);
            this.btnPersons.Text = "طرف حساب";
            this.btnPersons.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPersons.Click += new System.EventHandler(this.btnPersons_Click);
            // 
            // btnTransaction
            // 
            this.btnTransaction.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btnTransaction.Image = ((System.Drawing.Image)(resources.GetObject("btnTransaction.Image")));
            this.btnTransaction.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTransaction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(70, 67);
            this.btnTransaction.Text = "تراکنش جدید";
            this.btnTransaction.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // btnEditDebtor
            // 
            this.btnEditDebtor.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btnEditDebtor.Image = global::HesabDari.App.Properties.Resources.debit_card;
            this.btnEditDebtor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditDebtor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditDebtor.Name = "btnEditDebtor";
            this.btnEditDebtor.Size = new System.Drawing.Size(71, 67);
            this.btnEditDebtor.Text = "ویرایش درآمد";
            this.btnEditDebtor.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnEditDebtor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditDebtor.Click += new System.EventHandler(this.btnEditDebtor_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.toolStripButton1.Image = global::HesabDari.App.Properties.Resources.loan;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(73, 67);
            this.toolStripButton1.Text = "ویرایش هزینه";
            this.toolStripButton1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btnRefresh.Image = global::HesabDari.App.Properties.Resources.reload;
            this.btnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(60, 67);
            this.btnRefresh.Text = "بروزرسانی";
            this.btnRefresh.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDate,
            this.lblTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblDate
            // 
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 17);
            // 
            // lblTime
            // 
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBalance);
            this.groupBox1.Controls.Add(this.lblDebt);
            this.groupBox1.Controls.Add(this.lblCredite);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(444, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 104);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "گزارش یک ماه";
            // 
            // lblBalance
            // 
            this.lblBalance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblBalance.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblBalance.Location = new System.Drawing.Point(7, 65);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBalance.Size = new System.Drawing.Size(175, 19);
            this.lblBalance.TabIndex = 0;
            this.lblBalance.Text = "0";
            // 
            // lblDebt
            // 
            this.lblDebt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDebt.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblDebt.Location = new System.Drawing.Point(7, 41);
            this.lblDebt.Name = "lblDebt";
            this.lblDebt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDebt.Size = new System.Drawing.Size(175, 19);
            this.lblDebt.TabIndex = 0;
            this.lblDebt.Text = "0";
            // 
            // lblCredite
            // 
            this.lblCredite.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCredite.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblCredite.Location = new System.Drawing.Point(6, 15);
            this.lblCredite.Name = "lblCredite";
            this.lblCredite.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCredite.Size = new System.Drawing.Size(116, 21);
            this.lblCredite.TabIndex = 0;
            this.lblCredite.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(200, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "مانده (ریال) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(162, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "پرداختی ها (ریال) :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(166, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "دریافتی ها (ریال) :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HesabDari.App.Properties.Resources.Untitled_1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(424, 342);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // grbIndebtedness
            // 
            this.grbIndebtedness.Controls.Add(this.lblAmount);
            this.grbIndebtedness.Controls.Add(this.lblName);
            this.grbIndebtedness.Location = new System.Drawing.Point(444, 217);
            this.grbIndebtedness.Name = "grbIndebtedness";
            this.grbIndebtedness.Size = new System.Drawing.Size(328, 53);
            this.grbIndebtedness.TabIndex = 5;
            this.grbIndebtedness.TabStop = false;
            this.grbIndebtedness.Text = "بالاترین بدهکاری";
            this.grbIndebtedness.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblAmount
            // 
            this.lblAmount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAmount.ForeColor = System.Drawing.Color.Crimson;
            this.lblAmount.Location = new System.Drawing.Point(8, 19);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAmount.Size = new System.Drawing.Size(174, 21);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "0";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Crimson;
            this.lblName.Location = new System.Drawing.Point(228, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "بدهکار : ";
            // 
            // grbCreditor
            // 
            this.grbCreditor.Controls.Add(this.lblminAmount);
            this.grbCreditor.Controls.Add(this.lblMinName);
            this.grbCreditor.Location = new System.Drawing.Point(444, 276);
            this.grbCreditor.Name = "grbCreditor";
            this.grbCreditor.Size = new System.Drawing.Size(328, 64);
            this.grbCreditor.TabIndex = 5;
            this.grbCreditor.TabStop = false;
            this.grbCreditor.Text = "بالاترین بستانکاری";
            this.grbCreditor.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblminAmount
            // 
            this.lblminAmount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblminAmount.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblminAmount.Location = new System.Drawing.Point(7, 28);
            this.lblminAmount.Name = "lblminAmount";
            this.lblminAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblminAmount.Size = new System.Drawing.Size(174, 21);
            this.lblminAmount.TabIndex = 0;
            this.lblminAmount.Text = "0";
            // 
            // lblMinName
            // 
            this.lblMinName.AutoSize = true;
            this.lblMinName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinName.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblMinName.Location = new System.Drawing.Point(217, 30);
            this.lblMinName.Name = "lblMinName";
            this.lblMinName.Size = new System.Drawing.Size(70, 16);
            this.lblMinName.TabIndex = 0;
            this.lblMinName.Text = "بستانکار : ";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.grbCreditor);
            this.Controls.Add(this.grbIndebtedness);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حساب داری کیمیا";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbIndebtedness.ResumeLayout(false);
            this.grbIndebtedness.PerformLayout();
            this.grbCreditor.ResumeLayout(false);
            this.grbCreditor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolS00;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnPersons;
        private System.Windows.Forms.ToolStripButton btnTransaction;
        private System.Windows.Forms.ToolStripButton btnEditDebtor;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem btnManagmentOfUserAndPassword;
        private System.Windows.Forms.ToolStripMenuItem btnBackUp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblDebt;
        private System.Windows.Forms.Label lblCredite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.GroupBox grbIndebtedness;
        private System.Windows.Forms.GroupBox grbCreditor;
        private System.Windows.Forms.Label lblminAmount;
        private System.Windows.Forms.Label lblMinName;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblName;
    }
}

