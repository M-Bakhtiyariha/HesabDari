namespace HesabDari.App
{
    partial class frmTransaction
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAmount = new System.Windows.Forms.NumericUpDown();
            this.rdbCreditor = new System.Windows.Forms.RadioButton();
            this.rdbDebtor = new System.Windows.Forms.RadioButton();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPersonList = new System.Windows.Forms.DataGridView();
            this.PersonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nameof = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Family = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.rdbCreditor);
            this.groupBox1.Controls.Add(this.rdbDebtor);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(246, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 312);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(104, 96);
            this.txtAmount.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(164, 21);
            this.txtAmount.TabIndex = 3;
            // 
            // rdbCreditor
            // 
            this.rdbCreditor.AutoSize = true;
            this.rdbCreditor.Location = new System.Drawing.Point(104, 60);
            this.rdbCreditor.Name = "rdbCreditor";
            this.rdbCreditor.Size = new System.Drawing.Size(49, 17);
            this.rdbCreditor.TabIndex = 1;
            this.rdbCreditor.TabStop = true;
            this.rdbCreditor.Text = "درآمد";
            this.rdbCreditor.UseVisualStyleBackColor = true;
            // 
            // rdbDebtor
            // 
            this.rdbDebtor.AutoSize = true;
            this.rdbDebtor.Location = new System.Drawing.Point(213, 60);
            this.rdbDebtor.Name = "rdbDebtor";
            this.rdbDebtor.Size = new System.Drawing.Size(51, 17);
            this.rdbDebtor.TabIndex = 2;
            this.rdbDebtor.TabStop = true;
            this.rdbDebtor.Text = "هزینه";
            this.rdbDebtor.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(9, 141);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(259, 165);
            this.txtDescription.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(104, 20);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(164, 21);
            this.txtName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "توضیحات :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "مبلغ (ریال) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "نوع تراکنش :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام و نام خانوادگی :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPersonList);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Location = new System.Drawing.Point(9, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 312);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "لیست طرف حساب";
            // 
            // dgvPersonList
            // 
            this.dgvPersonList.AllowUserToAddRows = false;
            this.dgvPersonList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dgvPersonList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPersonList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonId,
            this.Nameof,
            this.Family});
            this.dgvPersonList.Location = new System.Drawing.Point(3, 46);
            this.dgvPersonList.Name = "dgvPersonList";
            this.dgvPersonList.ReadOnly = true;
            this.dgvPersonList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonList.Size = new System.Drawing.Size(222, 260);
            this.dgvPersonList.TabIndex = 0;
            this.dgvPersonList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonList_CellClick);
            // 
            // PersonId
            // 
            this.PersonId.DataPropertyName = "PersonId";
            this.PersonId.HeaderText = "شناسه";
            this.PersonId.Name = "PersonId";
            this.PersonId.ReadOnly = true;
            this.PersonId.Visible = false;
            // 
            // Nameof
            // 
            this.Nameof.DataPropertyName = "Name";
            this.Nameof.HeaderText = "نام";
            this.Nameof.Name = "Nameof";
            this.Nameof.ReadOnly = true;
            // 
            // Family
            // 
            this.Family.DataPropertyName = "Family";
            this.Family.HeaderText = "نام خانوادگی";
            this.Family.Name = "Family";
            this.Family.ReadOnly = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(3, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(222, 21);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 317);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "افزودن";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // frmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 353);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTransaction";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmTransaction_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPersonList;
        private System.Windows.Forms.NumericUpDown txtAmount;
        private System.Windows.Forms.RadioButton rdbCreditor;
        private System.Windows.Forms.RadioButton rdbDebtor;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nameof;
        private System.Windows.Forms.DataGridViewTextBoxColumn Family;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}