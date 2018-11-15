using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{

    /// <summary>
    /// Представляет установленную дату.
    /// </summary>
    public class MyDate
    {
        private bool currentLeap;
        private int _day;
        private int _month;
        private int _year;
        private int maxYear = 9999;
        private char[] _separator = { '.',  '/', '\\', '|', ',', '-' };

        /// <summary>
        /// Инициализирует новый экземпляр класса с текущей датой.
        /// </summary>
        public MyDate()
        {
            SetDate(DateTime.Now);
        }

        /// <summary>
        /// Инициализирует новый экземпляр классас заданной датой.
        /// </summary>
        /// <param name="date">Строка задающая дату</param>
        /// <param name="separator">Устанавливает используемый разделитель</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="FormatException"></exception>
        /// <exception cref="OverflowException"></exception>
        public MyDate(string date)
        {
            SetDate(date, _separator);
        }

        /// <summary>
        /// Инициализирует новый экземпляр классас заданной датой. Используемый разделитель будет изменен.
        /// </summary>
        /// <param name="date">Строка задающая дату</param>
        /// <param name="separator">Устанавливает используемый разделитель</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="FormatException"></exception>
        /// <exception cref="OverflowException"></exception>
        public MyDate(string date, params char[] separator)
        {
            _separator = separator;
            SetDate(date, _separator);
        }

        /// <summary>
        /// Инициализирует новый экземпляр классас заданной датой. Если значение chengeSeparator истинно, то используемый разделитель будет изменен, 
        /// иначе будет использоватся разделитель по умолчению.
        /// </summary>
        /// <param name="date">Строка задающая дату</param>
        /// <param name="separator">Устанавливает используемый разделитель</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="FormatException"></exception>
        /// <exception cref="OverflowException"></exception>
        public MyDate(string date, bool chengeSeparator, params char[] separator)
        {
            _separator = separator;
            SetDate(date, _separator);
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса с заданной в виде объекта DateTime датой.
        /// </summary>
        public MyDate(DateTime data)
        {
            Day = data.Day;
            Month = data.Month;
            Year = data.Year;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса с датой, заданной используя день, месяц и год.
        /// Если параметры принимают значения выходящие за границы допустимых, принимается ближайшее допустимое значение.
        /// </summary>
        /// <param name="day"></param>
        /// <param name="month"></param>
        /// <param name="year"></param>
        public MyDate(int day, int month, int year)
        {
            SetDate(day, month, year);
        }

        /// <summary>
        /// Задает новое значение даты из указанной строки используя заданный разделитель. При отсутствии данных задаются текущие.
        /// </summary>
        /// <param name="date">Строка задающая дату</param>
        /// <param name="separator">Устанавливает используемый разделитель</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="FormatException"></exception>
        /// <exception cref="OverflowException"></exception>
        public void SetDate(string date, params char[] separator)
        {
            string[] dateArr = date.Split(separator, 3);
            int N = dateArr.Length;

            if (dateArr.Length < 3)
                Year = DateTime.Now.Year;
            else
                Year = int.Parse(dateArr[2]); 

            if (dateArr.Length < 2)
                Month = DateTime.Now.Month;
            else
                Month = int.Parse(dateArr[1]);

            if (dateArr.Length == 1)
                Day = DateTime.Now.Day;
            else
                Day = int.Parse(dateArr[0]);
        }

        /// <summary>
        /// Задает новое значение даты используя щбъект DateTime.
        /// </summary>
        /// <param name="date"></param>
        public void SetDate(DateTime date)
        {
            Day = date.Day;
            Month = date.Month;
            Year = date.Year;
        }

        /// <summary>
        /// Задает новое значение даты используя день, месяц и год.
        /// Если параметры принимают значения выходящие за границы допустимых, принимается ближайшее допустимое значение.
        /// </summary>
        /// <param name="day">День может принимать значения от 1 до 31 в зависимости от месяца</param>
        /// <param name="month">Месяц может принимать значения от 1 до 12</param>
        /// <param name="year">Год от 0 дo 3999</param>
        public void SetDate(int day, int month, int year)
        {
            Year = year;
            Month = month;
            Day = day;
        }
        
        /// <summary>
        /// Задает значение нового разделителя.
        /// </summary>
        /// <param name="separator"></param>
        public void SetSeparator(params char[] separator)
        {
            _separator = separator;
        }

        /// <summary>
        /// Определение високостного года.
        /// </summary>
        /// <param name="year"></param>
        /// <returns>Возвращает true если год високостный</returns>
        public static bool LeapYear(int year)
        {
            if (year % 400 == 0) return true;
            if (year % 100 == 0) return false;
            if (year % 4 == 0) return true;
            return false;
        }

        /// <summary>
        /// Определение колличества дней выбранного месяца.
        /// </summary>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <returns></returns>
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
                    return LeapYear(year) ? 29 : 28;
                default:
                    return 30;
            }
        }

        /// <summary>
        /// Определение колличества дней в году.
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public static int YearDays(int year)
        {
            return (LeapYear(year)) ? 366 : 365;
        }

        /// <summary>
        /// Возвращает компоненту даты.
        /// </summary>
        public string Date
        {
            get {
                return string.Format("{0:D1}{3}{1:D2}{3}{2:D2}", Day, Month, Year, _separator[0]);
            }
        }

        /// <summary>
        /// Возвращает или задает компоненту дня даты.
        /// </summary>
        public int Day
        {
            set {
                _day = (value < MonthDays(Month, Year)) ? ((value > 0) ? value : 1) : MonthDays(Month, Year);
            }
            get {
                return _day;
            }
        }

        /// <summary>
        /// Возвращает или задает компоненту месяца даты.
        /// </summary>
        public int Month
        {
            set {
                switch (value) {
                    case 0:
                        _month = 12;
                        _year--;
                        break;
                    case 13:
                        _month = 1;
                        _year++;
                        break;
                    default:
                        _month = (value <= 12) ? (value > 0) ? value : 1 : 12;
                        break;
                }

            }
            get {
                return _month;
            }
        }

        /// <summary>
        /// Возвращает или задает компоненту года даты.
        /// </summary>
        public int Year {
            set {
                _year = (value < maxYear) ? ((value >= 0) ? value : 0) : maxYear;
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
        
        // Возвращает колличетсво дней между заданными датами. 
        public static int operator -(MyDate date1, MyDate date2)
        {
            if (date1 == date2) return 0;
            if (date1 < date2) return -(date2 - date1);
            if (date1.Year == date2.Year && date1.Month == date2.Month) return date1.Day - date2.Day;
            int count = 0, N;
            count += MonthDays(date2.Month, date2.Year) - date2.Day;
            count += date1.Day;
            N = (date1.Year == date2.Year) ? date1.Month-1 : 12;
            for (int i = date2.Month + 1; i <= N; i++)
                count += MonthDays(i, date2.Year);
            if (date1.Year == date2.Year) return count;
            for (int i = date2.Year + 1; i < date1.Year; i++)
                count += YearDays(i);
            for (int i = 1; i < date1.Month; i++)
                count += MonthDays(i, date1.Year);
            return count;
        }

        // Возвращает экземпляр класса с датой указанное колличество дней до заданной даты
        public static MyDate operator -(MyDate date, int days)
        {
            if (days < 0) return date + Math.Abs(days);

            MyDate result = new MyDate(date.Day, date.Month, date.Year);
            if (result.Day - days >= 1) {
                result.Day = date.Day - days;
                return result;
            }
            days -= result.Day - 1;
            result.Day = 1;
            if (days >= 365) {
                while (result.Month != 1) {
                    result.Month--;
                    days -= MonthDays(result.Month, result.Year);
                }
                while (days >= YearDays(result.Year)) {
                    result.Year--;
                    days -= YearDays(result.Year);
                }
            }
            while (days >= MonthDays(result.Month, result.Year)) {
                result.Month--;
                days -= MonthDays(result.Month, result.Year);
            }
            result.Month--;
            result.Day = MonthDays(result.Month, result.Year) - days +1;
            return result;
        }

        // Возвращает экземпляр класса с датой спустя указанное колличество дней
        public static MyDate operator +(MyDate date, int days)
        {
            if (days < 0) return date - Math.Abs(days);

            MyDate result = new MyDate(date.Day, date.Month, date.Year);
            if (days + result.Day <= MonthDays(result.Month, result.Year)) {
                result.Day = days + date.Day;
                return result;
            }
            days -= MonthDays(result.Month, result.Year) - result.Day + 1;
            result.Day = 1;
            result.Month++;
            if (days >= 365) {
                while (result.Month != 1) {
                    days -= MonthDays(result.Month, result.Year);
                    result.Month++;
                }
                int tmp = days / 146097;
                days -= 146097 * tmp;
                result.Year += 400 * tmp;

                tmp = days / 36524;
                days -= 36524 * tmp;
                result.Year += 100 * tmp;

                tmp = days / 1461;
                days -= 1461 * tmp;
                result.Year += 4 * tmp;

                while (days >= YearDays(result.Year)) {
                    days -= YearDays(result.Year);
                    result.Year++;
                }
            }
            while (days >= MonthDays(result.Month, result.Year)) {
                days -= MonthDays(result.Month, result.Year);
                result.Month++;
            }
            result.Day += days;
            return result;
        }
        
        public static MyDate operator +(int days, MyDate date)
        {
            return date + days;
        }


    }
}
