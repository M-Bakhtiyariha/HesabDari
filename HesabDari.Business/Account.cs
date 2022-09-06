using HesabDari.DataLayer.Context;
using HesabDari.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesabDari.Business
{
    public class Account
    {
        public static ReportViewModel ReportFormMain()
        {
            ReportViewModel rp = new ReportViewModel();
            using (UnitOfWork db = new UnitOfWork())
            {
                var firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

                var recive = db.AccountingRepository.Get(a => a.TypeId == 2 && a.Date >= firstDayOfMonth && a.Date <= lastDayOfMonth).Select(a => a.Amount).ToList();
                var pay = db.AccountingRepository.Get(a => a.TypeId == 1 && a.Date >= firstDayOfMonth && a.Date <= lastDayOfMonth).Select(a => a.Amount).ToList();

                rp.Recive = recive.Sum();
                rp.Pay = pay.Sum();
                rp.AccountBalamce = (recive.Sum() - pay.Sum());
            }
            return rp;
        }
    }
}
