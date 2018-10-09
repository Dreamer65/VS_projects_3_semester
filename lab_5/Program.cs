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
            Console.WriteLine(Leders(N)); // Вывод колличества
            
            if (args.Length == 0) {
                Console.WriteLine("\nНажмите любую клавишу..."); 
                Console.ReadKey();
            }
        }

        static int Leders_old(int N)
        {
            switch (N) {
                case 1:
                    return 1;
                case 2:
                    return 2;
                case 3:
                    return 4;
                default:
                    return Leders_old(N - 1) + Leders_old(N - 2) + Leders_old(N - 3);
            }

        }

        static long Leders(int N)
        {
            if (N <= 0) return 0;
            long sum = 0, n1 = 1, n2 = 2, n3 = 4;
            if (N <= 3)
            {
                switch (N)
                {
                    case 1: return n1;
                    case 2: return n2;
                    case 3: return n3;
                }
            }
            for (int i = 4; i <= N; i++)
            {
                sum = n1 + n2 + n3;
                n1 = n2;
                n2 = n3;
                n3 = sum;
            }
            return sum;
        }
    }
}
