using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace lab_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            while (true) {
                Console.Clear();
                if (!ConsoleDialog.ReadValue("Введите расположение солдат после команды:", out str)) {
                    ConsoleDialog.HoldToKeyPress("Строка не должна быть пустой.");
                    continue;
                }
                if (str.Length < 2) {
                    ConsoleDialog.HoldToKeyPress("Нужно хотябы 2 солдата.");
                    continue;
                }
                if (!Correct(str)) {
                    ConsoleDialog.HoldToKeyPress("В строке присудствуют недопустимые символы.");
                    continue;
                }
                break;
            }
            int i, pos, count = 0, countCurr, iter = 0;
            do {
                countCurr = 0;
                i = 0;
                while (i < str.Length) {
                    pos = str.Substring(i).IndexOf("><");
                    if (pos < 0) {
                        break;
                    }
                    countCurr++;
                    str = str.Remove(i+pos, 2).Insert(i+pos, "<>");
                    i += 2;
                }
                if (countCurr != 0) {
                    Console.WriteLine("После {0} серии расворотов:\n" + str, ++iter);
                    Console.WriteLine();
                    count += countCurr;
                }
            } while (countCurr != 0);
            ConsoleDialog.HoldToKeyPress(string.Format("Всего было совершено {0} пар разворотов за {1} серии.", count, iter));
        }

        static bool Correct(string str)
        {
            foreach(char st in str) {
                if (!"<>".Contains(st)) {
                    return false;
                }
            }
            return true;
        }
    }
}
