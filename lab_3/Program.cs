using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    class Program
    {
        static bool[] line = { true, false, false, true };
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Введите номер искомого элемента\nЭто должно быть положительное целое число");
                int N;
                if (!int.TryParse(Console.ReadLine(), out N) || N <= 0)
                {
                    Console.WriteLine("Неверный ввод");
                    Console.ReadKey();
                    return;
                }

                Console.WriteLine(FindIlement(N) ? 1 : 0);
                Console.ReadKey();
                return;
            }

            /*
             * Далее следует фрагмент для ввода данных через параметры
             * Работа в этом режиме возможна только при запуске через консоль
             * Данные вводятся через пробел в качестве параметра
             * пример:
             *      E:\<Path>\Debag> lab_3.exe <N1> <N2> ...
             *      где N1, N2, ... - положительные целые числа
             */

            Console.WriteLine("Множество элементов:");
            foreach (string str in args)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < args.Length; i++) 
            {
                int N;
                if (!int.TryParse(args[i], out N) || N <= 0)
                {
                    Console.WriteLine("Неверный ввод");
                }

                Console.WriteLine("Элемент № " + N + " -> " + (FindIlement(N) ? 1 : 0));
            }

        }
        
        static bool FindIlement(int N)
        {
            if (N <= 4)
            {
                return line[N-1];
            }
            
            int pow = 1;
            for (int i = 1; (int)Math.Pow(4, (double)i) < N; pow = i, i++) ;    // Находим максимальную степень 4х меньше N

            int pos = (int)Math.Ceiling(N / Math.Pow(4, (double)pow)); // Находим положение N относительно степени 4х
            return (pos == 4) ? FindIlement(N - (int)Math.Pow(4, (double)pow) * (pos - 1)) :  // Находим значения для (N - 4^pow) элемента
                !FindIlement(N - (int)Math.Pow(4, (double)pow) * (pos - 1)); // Если положение не 4 то отрицаем резельтат
        }
    }
}
