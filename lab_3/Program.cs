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
            Console.WriteLine("Введите номер искомого элемента\nЭто должно быть положительное целое число");
            int N;
            if (!int.TryParse(Console.ReadLine(), out N) || N <= 0)
            {
                Console.WriteLine("Неверный ввод");
                Console.ReadKey();
                return ;
            }

            Console.WriteLine(FindIlement(N)?1:0);
            Console.ReadKey();
            Console.Clear();
            Main(args);

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
            return (pos == 4) ? FindIlement(N - (int)Math.Pow(4, (double)pow) * (pos - 1)) :
                !FindIlement(N - (int)Math.Pow(4, (double)pow) * (pos - 1)); 
        }
    }
}
