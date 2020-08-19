using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Hw20
{
    public class Date_and_time
    {
        DateTime date;

        public DateClass()
        {
            date = new DateTime(2009, 1, 1);
        }

        public DateClass(DateTime date)
        {
            this.date = date;
        }

        public DateTime PrevDay()
        {
            return date.Subtract(TimeSpan.FromDays(1));
        }

        public DateTime NextDay()
        {
            return date.Add(TimeSpan.FromDays(1));
        }

        public int DaysLeft()
        {
            return DateTime.DaysInMonth(date.Year, date.Month) - date.Day;
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public override string ToString()
        {
            return date.ToString();
        }
    }
}
