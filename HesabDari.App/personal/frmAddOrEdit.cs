using HesabDari.DataLayer;
using HesabDari.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesabDari.App
{
    public partial class frmAddOrEdit : Form
    {
        public int personId = 0;
        UnitOfWork db;
        public frmAddOrEdit()
        {
            InitializeComponent();
        }

        private void frmAddOrEdit_Load(object sender, EventArgs e)
        {
            if (personId == 0)
            {
                this.Text = "افزودن شخص جدید";
            }
            else
            {
                db = new UnitOfWork();
                var newPerson = db.PersonRepository.GetById(personId);
                txtName.Text = newPerson.Name;
                txtFamily.Text = newPerson.Family;
                txtNationalCode.Text = newPerson.NationalCode;
                txtPhoneNumber.Text = newPerson.PhoneNumber;
                txtAddress.Text = newPerson.Address;
                pcPerson.ImageLocation = Application.StartupPath + "/Images" + newPerson.Picture;
                string fullName = txtName.Text + " " + txtFamily.Text;
                this.Text = $"ویرایش اطلاعات {fullName}";
                btnSubmit.Text = "ویرایش";

                db.Dispose();
            }

        }

        private void btnLoadPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                pcPerson.ImageLocation = open.FileName;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider1.SetError(txtName, "لطفاً یک نام وارد کنید");
            }
            else if (string.IsNullOrWhiteSpace(txtFamily.Text))
            {
                errorProvider1.SetError(txtFamily, "لطفاً نام خانوادگی را وارد کنید");
            }
            else if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                errorProvider1.SetError(txtPhoneNumber, "لطفاً شماره تلفن را وارد کنید");
            }
            else
            {
                db = new UnitOfWork();
                string imageName = Guid.NewGuid().ToString() + Path.GetExtension(pcPerson.ImageLocation);
                string path = Application.StartupPath + "/Images";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                pcPerson.Image.Save(path + imageName);

                Persons p1 = new Persons()
                {
                    Name = txtName.Text,
                    Family = txtFamily.Text,
                    NationalCode = txtNationalCode.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Address = txtAddress.Text,
                    Picture = imageName
                };
                if (personId == 0)
                {
                    db.PersonRepository.Insert(p1);
                }

                else
                {
                    p1.PersonId = personId;
                    db.PersonRepository.Update(p1);
                }
                db.Save();
                DialogResult = DialogResult.OK;
                db.Dispose();
            }

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}
