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
                if (N <= 1)
                {
                    Console.Clear();
                    if (N <= 0)
                    {
                        Console.WriteLine("Что-то пошло не так...");
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
            if (N != 1)
            {
                int i = N-1, pos=1;
                while (i >= 0)
                {
                    Console.WriteLine("На левой чаше весов лежат монеты с номерами:");
                    Console.WriteLine(pos + " - " + (int)(pos + (int)Math.Pow(3, (double)i)-1) + "\n");

                    Console.WriteLine("На правой чаше весов лежат монеты с номерами:");
                    Console.WriteLine((int)(pos + Math.Pow(3, (double)i)) + " - " + (int)(pos + 2 * Math.Pow(3, (double)i)-1) + "\n");

                    Console.WriteLine("Что происходит на весах?");
                    Console.WriteLine("1 - левая чаша перевесила");
                    Console.WriteLine("2 - правая чаша перевесила");
                    Console.WriteLine("3 - чаши в равновесии");
                    char key = Console.ReadKey(true).KeyChar;
                    switch (key)
                    {
                        case '1':
                            Console.WriteLine("Левая чаша перевесила.");
                            break;
                        case '2':
                            Console.WriteLine("Правая чаша перевесила");
                            pos += (int)Math.Pow(3, (double)i);
                            break;
                        case '3':
                            Console.WriteLine("Чаши уравновешены");
                            pos += 2*(int)Math.Pow(3, (double)i);
                            break;
                        default:
                                Console.WriteLine("Возникла ошибка");
                                return ;
                    }
                    i--;
                    Console.Clear();

                }
                Console.WriteLine(pos);
                Console.ReadKey(true);
            }
        }

        static private int GetN()
        {
            while (true)
            {
                Console.WriteLine("Введите N (N должно быть целым числом)");
                /*
                 *  В VS2013 Сообщается об ошибке в строке
                 *  if (int.TryParse(Console.ReadLine(), out int N))
                 *  Ошибки здесь нет для VS2017 
                 *  А VS2013 может скомпилировать ее
                 *  Вероятнее всего VS2013 считает ее ошибкой для более старой версии .NET
                */
                int N;
                if (int.TryParse(Console.ReadLine(), out N))
                {
                    return N;
                }
                else
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
