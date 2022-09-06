using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace HesabDari.Utility.Convertor
{
    public  static class DateConvertor
    {
        public static string ToShamsi(this DateTime date)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetYear(date).ToString() + "/" + pc.GetMonth(date).ToString("00/") + pc.GetDayOfMonth(date).ToString("00");
        }

        public static DateTime ToMiladi(DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, new System.Globalization.PersianCalendar());
        }
    }
}
