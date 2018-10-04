using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            if (args.Length == 0) Console.WriteLine("Введите номер ступеньки:");
            if (!int.TryParse((args.Length == 0) ? Console.ReadLine() : args[0], out N) || N <= 0)
            {
                Console.WriteLine("Ошибка ввода\nНажмите любую клавишу...");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Способов поднятся на эту ступеньку у зайца:");
            Console.WriteLine(Leders(N)+"\nНажмите любую клавишу...");
            Console.ReadKey();
        }

        static int Leders(int N)
        {
            switch (N) {
                case 1:
                    return 1;
                case 2:
                    return 2;
                case 3:
                    return 4;
                default:
                    return Leders(N - 1) + Leders(N - 2) + Leders(N - 3);
            }

        }
    }
}
