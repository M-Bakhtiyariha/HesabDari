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
using HesabDari.Utility.Convertor;
using HesabDari.ViewModel;

namespace HesabDari.App.Accounting
{
    public partial class frmCredite : Form
    {
        UnitOfWork db;
        public int kindOfTransaction = 0;
        public frmCredite()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void Filter()
        {
            db = new UnitOfWork();
            //فیلتر بر اساس کمبو باکس و تاریخ
            List<DataLayer.Accounting> result = new List<DataLayer.Accounting>();
            //دو متغیر زیر که از نوع دیت تایم می باشند و علامت سوال نیز به معنی نال پذیر 
            //بودن دو متغیر است
            DateTime? startDate;
            DateTime? endDate;
            //خطوط زیر با توجه به شرط ابتدا از طریق کمبو باکس شناسه شخص را استخراج می کند
            //و به دلیل اینکه مقدار شرط صفر نیست یک شخص را با توجه به طلبکار یا بستانکار بودن بر می گرداند 
            //ودر غیر این صورت همه را بر می گرداند
            if ((int)cmbPersons.SelectedValue != 0)
            {
                int personId =Convert.ToInt32(cmbPersons.SelectedValue.ToString());
                result.AddRange(db.AccountingRepository.Get(t => t.TypeId == kindOfTransaction && t.PersonId == personId));
            }
            else
            {
                result.AddRange(db.AccountingRepository.Get(t => t.TypeId == kindOfTransaction).ToList());
            }
            //بخش دوم فیلتر اختصاص به تاریخ دارد ابتدا در بالا دو و بنا به نیاز بانک که از 
            //نوع تاریخ می باشد دو متغیر از نوع تاریخ تعریف می کنیم و انها را نال پذیر قرار 
            //می دهیم سپس با بررسی اینکه داخل تکست باکسهای مربوط به تاریخ خالی نباشند وارد بدنه
            //شرط ها شده و سپس دو متغیر تاریخ بالا را با توجه به مقادر درون تکسک باکس ها مقدار دهی 
            //می کنیم سپس آنها را با یک متد به میلادی تبدیل می کنیم چون در جدول بانک باید به میلادی
            //ذخیره شده تا بتوان در بحث گزارش گیری از آن استفاده کرد
            //ودر آخر نیز برای اینکه بتوانیم تاریخ ها را فیلتر کنیم باید در لیست ریزالت تعریف شده در
            //بالا بررسی کنیم که تاریخ ها از مقادیر تعریف شده کوچکتر یا بزرگتر باشند
            if (txtFromDate.Text != "    /  /")
            {
                startDate = Convert.ToDateTime(txtFromDate.Text);
                startDate = DateConvertor.ToMiladi(startDate.Value);
                result = result.Where(r => r.Date >= startDate.Value).ToList();
            }
            if (txtToDate.Text != "    /  /")
            {
                endDate = Convert.ToDateTime(txtToDate.Text);
                endDate = DateConvertor.ToMiladi(endDate.Value);
                result = result.Where(r => r.Date <= endDate.Value).ToList();
            }

            dgvDebters.Rows.Clear();
            foreach (var accounting in result)
            {
                string name = db.PersonRepository.GetNameById(accounting.PersonId);
                string Family = db.PersonRepository.GetFamilyById(accounting.PersonId);
                dgvDebters.Rows.Add(accounting.id, accounting.PersonId, name, Family, accounting.Amount, accounting.Date.ToShamsi(), accounting.Description);
            }
            db.Dispose();
        }

        private void frmCredite_Load(object sender, EventArgs e)
        {
            if (kindOfTransaction == 1)
            {
                this.Text = "جزئیات هزینه";
            }
            else
            {
                this.Text = "جزئیات درآمد";
            }
            //اختصاص مقادیر به کمبو باکس
            db = new UnitOfWork();
            List<ListPersonsViewModel> list = new List<ListPersonsViewModel>();
            list.Add(new ListPersonsViewModel()
            {
                Name = "لطفاً انتخاب کنید",
                PersonId = 0
            });
            //اگر در بخش زیر به جای متد مشخص شده اقدام به برگرداندن همه اطلاعات کنیم
            //به ناچار رم را اشغال خواهیم کرد چون ما فقط شناسه و نام را لازم داریم
            //پس از متدی استفاده می کنیم که فقط موارد مورد نیاز را برگرداند
            list.AddRange(db.PersonRepository.GetPersonsName());
            cmbPersons.DataSource = list;
            cmbPersons.DisplayMember = "Name";
            cmbPersons.ValueMember = "PersonId";
            db.Dispose();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmTransaction edit = new frmTransaction();
            int personid = Int32.Parse(dgvDebters.CurrentRow.Cells[0].Value.ToString());
            edit.accountId = personid;
            if (edit.ShowDialog() == DialogResult.OK)
            {
                Filter();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Filter();
            cmbPersons.SelectedIndex = 0;
            btnShow_Click(null,null);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable print = new DataTable();
            print.Columns.Add("Name");
            print.Columns.Add("Family");
            print.Columns.Add("Amount");
            print.Columns.Add("Date");
            print.Columns.Add("Description");
            foreach (DataGridViewRow item in dgvDebters.Rows)
            {
                print.Rows.Add(
                    item.Cells[2].Value.ToString(),
                    item.Cells[3].Value.ToString(),
                    item.Cells[4].Value.ToString(),
                    item.Cells[5].Value.ToString(),
                    item.Cells[6].Value.ToString()
                    );
            }
            stiPrint.Load(Application.StartupPath + "/Report.mrt");
            stiPrint.RegData("DT", print);
            stiPrint.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDebters.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvDebters.CurrentRow.Cells[0].Value.ToString());
                if (RtlMessageBox.Show($"آیا از حذف این تراکنش اطمینان دارید ", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db = new UnitOfWork();
                    db.AccountingRepository.Delete(id);
                    db.Save();
                    Filter();
                    db.Dispose();
                }
            }
        }
    }
}
