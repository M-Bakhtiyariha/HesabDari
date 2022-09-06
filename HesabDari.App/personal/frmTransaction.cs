using HesabDari.DataLayer;
using HesabDari.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesabDari.App
{
    public partial class frmTransaction : Form
    {
        UnitOfWork db;
        //public int personId = 0;
        public int accountId = 0;
        public frmTransaction()
        {
            InitializeComponent();
        }

        private void frmTransaction_Load(object sender, EventArgs e)
        {
            BindGrid();
            if (accountId == 0)
            {
                this.Text = "افزودن تراکنش";
            }
            else
            {
                db = new UnitOfWork();
                this.Text = "ویرایش تراکنش";
                btnAdd.Text = "ویرایش";
                var newTransaction = db.AccountingRepository.GetById(accountId);
                string name = db.PersonRepository.GetNameById(newTransaction.PersonId);
                string family = db.PersonRepository.GetFamilyById(newTransaction.PersonId);
                string fullName = name + " " + family;
                txtName.Text = fullName;
                txtAmount.Value = Convert.ToDecimal(newTransaction.Amount.ToString());
                txtDescription.Text = newTransaction.Description;
                if (newTransaction.TypeId == 1)
                {
                    rdbDebtor.Checked = true;
                }
                else
                {
                    rdbCreditor.Checked = true;
                }
                db.Dispose();
            }
        }

        private void BindGrid()
        {
            db = new UnitOfWork();
            dgvPersonList.AutoGenerateColumns = false;
            dgvPersonList.DataSource = db.PersonRepository.Get();
            db.Dispose();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            db = new UnitOfWork();
            dgvPersonList.DataSource = db.PersonRepository.Get(p => p.Name.Contains(txtSearch.Text)
            || p.Family.Contains(txtSearch.Text));
            db.Dispose();
        }

        private void dgvPersonList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = dgvPersonList.CurrentRow.Cells[1].Value.ToString();
            string family = dgvPersonList.CurrentRow.Cells[2].Value.ToString();
            string fullName = name + " " + family;
            txtName.Text = fullName;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            db = new UnitOfWork();
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider1.SetError(txtName, "طرف حساب را انتخاب کنید");
            }
            else if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                errorProvider1.SetError(txtAmount, "مبلغ را وارد کنید");
            }
            else
            {  
                if (!rdbCreditor.Checked || !rdbDebtor.Checked)
                {

                    DataLayer.Accounting account = new DataLayer.Accounting()
                    {
                        TypeId = (rdbCreditor.Checked) ? 2 : 1,
                        Amount = double.Parse(txtAmount.Value.ToString()),
                        Date = DateTime.Now,
                        PersonId = Int32.Parse(dgvPersonList.CurrentRow.Cells[0].Value.ToString()),
                        Description = txtDescription.Text
                    };
                    if (accountId == 0)
                    {
                        db.AccountingRepository.Insert(account);
                    }
                    else
                    {
                        account.id = accountId;
                        db.AccountingRepository.Update(account);
                    }
                    db.Save();
                    db.Dispose();
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    RtlMessageBox.Show("نوع تراکنش را انتخاب کنید");
                }

            }
        }
    }
}

