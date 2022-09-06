using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesabDari.App
{
    public partial class frmBackUp : Form
    {
        public frmBackUp()
        {
            InitializeComponent();
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            bool mybackup = true;
            Cursor.Current = Cursors.WaitCursor;
            if (Directory.Exists(@"D:\sqlbackup\HesabDari"))
            {
                if (File.Exists(@"D:\sqlbackup\HesabDari\backup.bak"))
                {
                    if (MessageBox.Show("آیا قصد پشتیبان گیری مجدد دارید؟ ", "پشتیبان گیری", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        File.Delete(@"D:\sqlbackup\HesabDari\backup.bak");
                        MessageBox.Show("جهت جایگزینی فایل پشتیبان بر روی پشتیبان گیری اطلاعات کلیک کنید ", "پشتیبان گیری", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        mybackup = false;
                    }
                }
                else
                {
                    Directory.CreateDirectory(@"D:\sqlbackup\HesabDari");
                    if (mybackup)
                    {
                        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=HesabDari;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
                        con.Open();
                        SqlCommand com = new SqlCommand(@"Backup DataBase HesabDari to disk = 'D:\sqlbackup\HesabDari\backup.bak'with init , stats = 10", con);
                        com.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("پشتیبان گیری با موفقیت انجام شد", "پشتیبان گیری", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (File.Exists(@"D:\sqlbackup\HesabDari\backup.bak"))
                {
                    if (MessageBox.Show("آیا مایل به باز گردانی اطلاعات هستید؟", "بازیابی اطلاعات", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=HesabDari;Integrated Security=True;Application Name=EntityFramework");
                        connection.Open();
                        SqlCommand command;
                        command = new SqlCommand("Restore My DataBase", connection);
                        command.ExecuteNonQuery();
                        command = new SqlCommand(@"Restore DataBase HesabDari From Disk = 'D:\sqlbackup\HesabDari\backup.bak'", connection);
                        command.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("بازیابی اطلاعات با موفقیت انجام گرفت", "بازیابی اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("بانک اطلاعاتی جهت بازیابی پیدا نشد");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }

        private void frmBackUp_Load(object sender, EventArgs e)
        {

        }
    }
}
