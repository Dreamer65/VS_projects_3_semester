using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rectangle = new int[2];
            if (args.Length == 0) Console.WriteLine("Введите длинны сторон прямоугольника");
            for (int i = 0; i < 2; i++)
                if (!int.TryParse((args.Length == 0)?Console.ReadLine():args[i], out rectangle[i]) || rectangle[i] <= 0)
                {
                    Console.WriteLine("Неверный ввод\nНажмите любую кнопку...");
                    Console.ReadKey();
                    return;
                }
            if (rectangle[0] == rectangle[1])
            {
                    Console.WriteLine("Он сам квадрат. Поэтому он 1)))");
                    Console.ReadKey();
                    return;
            }

            int count = 0;

            do
            {
                if (rectangle[0] > rectangle[1])
                {
                    int t = rectangle[0];
                    rectangle[0] = rectangle[1];
                    rectangle[1] = t;
                }
                count += rectangle[1] / rectangle[0];
                rectangle[1] %= rectangle[0];
                if (rectangle[1] == 0)
                {
                    count--;
                    break;
                }
            }
            while (rectangle[0] != rectangle[1]);
            Console.WriteLine("Делится на " + ++count + " квадратов максимальной площади\nНажмите любую кнопку...");
            Console.ReadKey();
        }
    }
}
