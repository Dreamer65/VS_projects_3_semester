using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
                while (!ConsoleDialog.ReadValue("Введите две даты через пробел:", out args, ' '))
                    Console.WriteLine("\nПопробуйте снова...");
            if(args.Length == 1) {
                Console.WriteLine("Введите вторую дату:");
                args = (args[0] + '|' + Console.ReadLine()).Split('|');
            }
            if (args.Length == 0) {
                ConsoleDialog.HoldToKeyPress("Ошибка ввода");
                return;
            }

            MyDate date1, date2;
            try {
                date1 = new MyDate(args[0]);
                date2 = new MyDate(args[1]);
            }
            catch {
                ConsoleDialog.HoldToKeyPress("Ошибка ввода");
                return;
            }

            int gap = date1 - date2;
            if (gap > 0) 
                Console.WriteLine("{0} будет через {2} дней после {1}", date1.Date, date2.Date, gap);
            else
                Console.WriteLine("{0} было за {2} дней до {1}", date1.Date, date2.Date, Math.Abs(gap));
            ConsoleDialog.HoldToKeyPress();
        }
    }
}
