namespace HesabDari.App.Accounting
{
    partial class frmCredite
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtToDate = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFromDate = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPersons = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDebters = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameOf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Family = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stiPrint = new Stimulsoft.Report.StiReport();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebters)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEdit,
            this.btnDelete,
            this.btnRefresh,
            this.btnPrint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(684, 61);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = global::HesabDari.App.Properties.Resources._1371475973_document_edit;
            this.btnEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(46, 58);
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::HesabDari.App.Properties.Resources._1371476007_Close_Box_Red;
            this.btnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(44, 58);
            this.btnDelete.Text = "حذف";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::HesabDari.App.Properties.Resources._1371476342_Refresh;
            this.btnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(63, 58);
            this.btnRefresh.Text = "بروزرسانی";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = global::HesabDari.App.Properties.Resources._1371476193_printers___Faxes;
            this.btnPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(44, 58);
            this.btnPrint.Text = "چاپ";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Controls.Add(this.txtToDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFromDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbPersons);
            this.groupBox1.Location = new System.Drawing.Point(0, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 59);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(12, 19);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 30);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "نمایش";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(141, 25);
            this.txtToDate.Mask = "0000/00/00";
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtToDate.Size = new System.Drawing.Size(98, 21);
            this.txtToDate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "تا تاریخ :";
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(293, 25);
            this.txtFromDate.Mask = "0000/00/00";
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFromDate.Size = new System.Drawing.Size(98, 21);
            this.txtFromDate.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "از تاریخ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(608, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "طرف حساب :";
            // 
            // cmbPersons
            // 
            this.cmbPersons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersons.FormattingEnabled = true;
            this.cmbPersons.Location = new System.Drawing.Point(448, 25);
            this.cmbPersons.Name = "cmbPersons";
            this.cmbPersons.Size = new System.Drawing.Size(154, 21);
            this.cmbPersons.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDebters);
            this.groupBox2.Location = new System.Drawing.Point(0, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(684, 231);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اطلاعات";
            // 
            // dgvDebters
            // 
            this.dgvDebters.AllowUserToAddRows = false;
            this.dgvDebters.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            this.dgvDebters.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDebters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDebters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDebters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.PersonId,
            this.NameOf,
            this.Family,
            this.Amount,
            this.Date,
            this.Description});
            this.dgvDebters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDebters.Location = new System.Drawing.Point(3, 17);
            this.dgvDebters.Name = "dgvDebters";
            this.dgvDebters.ReadOnly = true;
            this.dgvDebters.Size = new System.Drawing.Size(678, 211);
            this.dgvDebters.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "شناسه";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // PersonId
            // 
            this.PersonId.DataPropertyName = "PersonId";
            this.PersonId.HeaderText = "شناسه شخص";
            this.PersonId.Name = "PersonId";
            this.PersonId.ReadOnly = true;
            this.PersonId.Visible = false;
            // 
            // NameOf
            // 
            this.NameOf.DataPropertyName = "Name";
            this.NameOf.HeaderText = "نام";
            this.NameOf.Name = "NameOf";
            this.NameOf.ReadOnly = true;
            // 
            // Family
            // 
            this.Family.DataPropertyName = "Family";
            this.Family.HeaderText = "نام خانوادگی";
            this.Family.Name = "Family";
            this.Family.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "مبلغ";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "تاریخ";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "توضیحات";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // stiPrint
            // 
            this.stiPrint.CookieContainer = null;
            this.stiPrint.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiPrint.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiPrint.ReportAlias = "Report";
            this.stiPrint.ReportGuid = "c689e729093f48ea9333a4e88b8a76ce";
            this.stiPrint.ReportName = "Report";
            this.stiPrint.ReportSource = null;
            this.stiPrint.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.stiPrint.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiPrint.UseProgressInThread = false;
            // 
            // frmCredite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCredite";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmCredite_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.MaskedTextBox txtToDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtFromDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPersons;
        private System.Windows.Forms.DataGridView dgvDebters;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Family;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private Stimulsoft.Report.StiReport stiPrint;
    }
}