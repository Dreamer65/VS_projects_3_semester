using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            while (true)
            {
                Console.WriteLine("Перед вами 3^N монет");
                N = GetN();
                if (N <= 0)
                {
                    Console.Clear();
                    if (N != 0)
                    {
                        Console.WriteLine("Что-то пошло не так...");
                        Console.WriteLine("Не стоило вводить отрицательное число...");
                    }
                    else
                        Console.WriteLine("Одна монета? Серьзно?");
                    Console.WriteLine("Попробовать снова(y\\n)?");
                    if (!YN_Dialog())
                    {
                        Console.Clear();
                        return;
                    }
                    else
                    {
                        Console.Clear();
                        continue;
                    }
                }
                break;
            }

            Console.WriteLine("Перед вами " + Math.Pow(3, (double)N)  + " монет.");
            if(N!=1)
                for(int i=0; i<N; i++)
                {

                }
        }

        static private int GetN()
        {
            while (true)
            {
                Console.WriteLine("Введите N (N должно быть целым числом)");
                try
                {
                    int N = int.Parse(Console.ReadLine());
                    return N;
                }
                catch
                {
                    Console.WriteLine("N должно быть целым числом...");
                    Console.WriteLine("Попробуем ещё(y\\n)?");
                    if (YN_Dialog())
                        continue;
                    else
                        return -1;
                }
            }
        } 

        static private bool YN_Dialog()
        {
            while (true)
            {
                char key = Char.ToUpper(Console.ReadKey(true).KeyChar);
                Console.WriteLine();
                if (key == 'Y' || key == 'Н')
                    return true;
                if (key == 'N' || key == 'Т')
                    return false;
                Console.WriteLine("Ты сейчас серьёзно? Нажми Y или N.");
            }
        }
    }
}
