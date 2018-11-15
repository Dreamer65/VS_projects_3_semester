using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_11_new_order_
{
    class Program
    {
        struct MinMax
        {
            public int min;
            public int minIndex;
            public int max;
            public int maxIndex;
        }

        static void Main(string[] args)
        {
            while (args.Length == 0) {
                MyLibrary.ConsoleDialog.ReadValue("Введите несколько слов через пробел", out args, ' ');
                MyLibrary.Functions.ArrayDelEmpty(ref args);
            }
            MinMax words;
            words = WordsMaxMinLength(args);
            Console.WriteLine("Минимальная длинна у слова {0} = {1}\nМаксимальная длинна у слова {2} = {3}", args[words.minIndex], words.min, args[words.maxIndex], words.max);
            MyLibrary.ConsoleDialog.HoldToKeyPress();
        }

        static MinMax WordsMaxMinLength(params string[] words)
        {
            MinMax len;
            len.max = words[0].Length;
            len.min = words[0].Length;
            len.minIndex = 0;
            len.maxIndex = 0;
            int index = 0;
            foreach (string str in words) {
                if (str.Length < len.min) {
                    len.min = str.Length;
                    len.minIndex = index++;
                    continue;
                }
                if (str.Length > len.max) {
                    len.max = str.Length;
                    len.maxIndex = index++;
                    continue;
                }
                index++;
            }
            return len;
        }
    }
}
