using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_10
{
    class MyDate
    {
        private bool currentLeap;
        private int _day;
        private int _month;
        private int _year;

        public MyDate()
        {
            SetDate(DateTime.Now.Date.ToString().Substring(0, 10), ".");
        }

        public MyDate(string date, string separator = ".")
        {
            SetDate(date, separator);
        }

        public void SetDate(string date, string separator)
        {
            string[] dateArr = date.Split(separator.ToCharArray(), 3);
            int N = dateArr.Length;

            if (date.Length < 3)
                Year = DateTime.Now.Year;
            else
                Year = int.Parse(dateArr[2]);

            if (date.Length < 2)
                Month = DateTime.Now.Month;
            else
                Month = int.Parse(dateArr[1]);

            if (date.Length == 1)
                Day = DateTime.Now.Day;
            else
                Day = int.Parse(dateArr[0]);
        }

        public static bool LeapYear(int year)
        {
            if (year % 400 == 0) return true;
            if (year % 100 == 0) return false;
            if (year % 4 == 0) return true;
            return false;
        }

        public static int MonthDays(int month, int year)
        {
            if (month > 12) return -1;
            switch (month) {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    return (LeapYear(year)) ? 29 : 28;
                default:
                    return 30;
            }
        }

        public static int YearDays(int year)
        {
            return (LeapYear(year)) ? 366 : 365;
        }

        public string Date
        {
            set {
                SetDate(value, ".");
            }
            get {
                return string.Format("{0:D2}.{1:D2}.{2:D2}", Day, Month, Year);
            }
        }

        public int Day
        {
            set {
                _day = (value < MonthDays(Month, Year)) ? value : MonthDays(Month, Year);
            }
            get {
                return _day;
            }
        }

        public int Month
        {
            set {
                _month = (value <= 12) ? value : 12;
            }
            get {
                return _month;
            }
        }

        public int Year {
            set {
                _year = (value < 3000) ? ((value >= 0) ? value : 0) : 2999;
                currentLeap = LeapYear(_year);
            }
            get {
                return _year;
            }
        }

        public static bool operator >(MyDate date1, MyDate date2)
        {
            if (date1.Year < date2.Year) return false;
            if (date1.Year > date2.Year) return true;
            if (date1.Month < date2.Month) return false;
            if (date1.Month > date2.Month) return true;
            if (date1.Day <= date2.Day) return false;
            return true;
        }

        public static bool operator <(MyDate date1, MyDate date2)
        {
            if (date1.Year > date2.Year) return false;
            if (date1.Year < date2.Year) return true;
            if (date1.Month > date2.Month) return false;
            if (date1.Month < date2.Month) return true;
            if (date1.Day >= date2.Day) return false;
            return true;
        }

        public static bool operator ==(MyDate date1, MyDate date2)
        {
            if (date1.Year != date2.Year) return false;
            if (date1.Month != date2.Month) return false;
            if (date1.Day != date2.Day) return false;
            return true;
        }

        public static bool operator !=(MyDate date1, MyDate date2)
        {
            return !(date1 == date2);
        }

        public static bool operator <=(MyDate date1, MyDate date2)
        {
            return !(date1 > date2);
        }

        public static bool operator >=(MyDate date1, MyDate date2)
        {
            return !(date1 < date2);
        }

        public static int operator -(MyDate date1, MyDate date2)
        {
            if (date1 == date2) return 0;
            if (date1 < date2) return -(date2 - date1);
            if (date1.Year == date2.Year && date1.Month == date2.Month) return date1.Day - date2.Day;
            int count = 0, N;
            count += MonthDays(date2.Month, date2.Year) - date2.Day;
            count += date1.Day;
            N = (date1.Year == date2.Year) ? date1.Month : 12;
            for (int i = date2.Month + 1; i <= N; i++)
                count += MonthDays(i, date2.Year);
            if (date1.Year == date2.Year) return count;
            for (int i = date2.Year + 1; i < date1.Year; i++)
                count += YearDays(i);
            for (int i = 1; i < date1.Month; i++)
                count += MonthDays(i, date1.Year);
            return count;
        }
    }
}
