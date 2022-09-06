using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HesabDari.DataLayer.Context;

namespace HesabDari.App
{
    public partial class frmLogin : Form
    {
        public bool isEdit = false;
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName, "لطفاً  نام کاربری را وارد کنید");
            }
            else if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "لطفاً گذرواژه را وارد کنید");
            }
            else
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    if (isEdit)
                    {
                        var loginer = db.LoginRepository.Get().First();
                        loginer.UserName = txtUserName.Text;
                        loginer.Password = txtPassword.Text;
                        db.LoginRepository.Update(loginer);
                        db.Save();
                        Application.Restart();
                    }
                    else
                    {
                        if (db.LoginRepository.Get(l => l.UserName == txtUserName.Text && l.Password == txtPassword.Text).Any())
                        {
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            RtlMessageBox.Show("کاربری یافت نشد");
                            txtUserName.ResetText();
                            txtPassword.ResetText();
                        }
                    }   
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if(isEdit)
            {
                this.Text = "ویرایش اطلاعات";
                btnEnter.Text = "ذخیره";
                using (UnitOfWork db = new UnitOfWork())
                {
                    var loginer = db.LoginRepository.Get().First();
                    txtUserName.Text = loginer.UserName;
                    txtPassword.Text = loginer.Password;
                }
            }
        }
    }
}
