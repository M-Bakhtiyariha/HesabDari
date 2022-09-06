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
    public partial class frmPersons : Form
    {
        UnitOfWork db;
        public frmPersons()
        {
            InitializeComponent();
        }

        private void frmPersons_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
        private void BindGrid()
        {
            db = new UnitOfWork();
            dgvPersons.AutoGenerateColumns = false;
            dgvPersons.DataSource = db.PersonRepository.Get();
            db.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BindGrid();
            txtSearch.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPersons.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvPersons.CurrentRow.Cells[0].Value.ToString());
                string name = dgvPersons.CurrentRow.Cells[2].Value.ToString();
                string family = dgvPersons.CurrentRow.Cells[3].Value.ToString();
                string fullName = name + " " + family;
                if (RtlMessageBox.Show($"آیا از حذف {fullName} اطمینان دارید ", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db = new UnitOfWork();
                    db.PersonRepository.Delete(id);
                    db.Save();
                    BindGrid();
                    db.Dispose();
                }
            }
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            db = new UnitOfWork();
            dgvPersons.DataSource = db.PersonRepository.Get(p => p.Name.Contains(txtSearch.Text)
            || p.Family.Contains(txtSearch.Text) || p.PhoneNumber.Contains(txtSearch.Text) || p.NationalCode.Contains(txtSearch.Text)).ToList();
            db.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddOrEdit add = new frmAddOrEdit();
            if (add.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmAddOrEdit edit = new frmAddOrEdit();
            int id = Convert.ToInt32(dgvPersons.CurrentRow.Cells[0].Value.ToString());
            edit.personId = id;
            if (edit.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }
    }
}
