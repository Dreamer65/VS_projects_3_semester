using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_9
{
    class Program
    {
        private const string gl = "АаЕеЁёИиОоУуЫыЭэЮюЯя"; // ы?
        private const string sogl = "БбВвГгДдЖжЗзЙйКкЛлМмНнПпРрСсТтФфХхЦцЧчШшЩщЪъЬь";
        private const string special = "ЙйЫыЪъЬь";

        static void Main(string[] args)
        {
            if (args.Length == 0) {
                Console.WriteLine("Введите колличество слов");
                int N;
                if(!int.TryParse(Console.ReadLine(), out N)) {
                    Console.WriteLine("Error");
                    return;
                }
                args = new string[N];
                for (int i = 0; i < N; i++) {
                    Console.WriteLine("Введите {0} слово:", i+1);
                    args[i] = Console.ReadLine();
                }
            }
            foreach (string str in args) {
                Console.WriteLine(Wrap(str));
            }
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }

        static byte CountGl(string str)
        {
            byte count = 0;
            foreach (char cr in str)
                if (gl.Contains(cr))
                    count++;
            return count;
        }

        /*
         * static bool BadWord(string str)
         * 
         * Проверка слова на некорректность
         * Если в строке str присудствуют символы не относящиеся
         * к кирилеце будет возвращено trye
         * Если str содержит только символы кирилици
         * будет возвращено false
         */
        static bool BadWord(string str)
        {
            foreach (char cr in str) {
                if (!(gl + sogl).Contains(cr))
                    return true;
            }
            return false;
        }

        static string Wrap(string str)
        {
            if (str.Length < 4) // Если в слове < 4 букв, то перенос невозможен
                return str;
            int countGl = CountGl(str);
            int count = 0, glCurent = 0;
            if (countGl < 2) // Если в слове нет хотя бы 2 гласных, то перенос невозможен
                return str;
            if (BadWord(str))
                return str + "|BAD|";
            int i = -1;
            while (i < str.Length - 1) {
                i++;
                count++;
                if (glCurent + countGl <= 1)
                    break;
                if (str[i] == '-') {
                    count = 0;
                    glCurent = 0;
                    continue;
                }
                if (sogl.Contains(str[i])) { // согласные
                    if (glCurent == 0) continue;
                }

                if (str.Length - i == countGl)
                    break;
                if (gl.Replace("Ыы", "").Contains(str[i])) {
                    countGl--;
                    glCurent++;
                    while (gl.Replace("Ыы", "").Contains(str[i + 1]) && gl.Replace("Ыы", "").Contains(str[i + 2])) {
                        i++;
                        countGl--;
                        glCurent++;
                        count++;
                    }
                }

                if (special.Contains(str[i])) { // исключения
                    if ("Ыы".Contains(str[i])) {
                        glCurent++;
                        countGl--;
                    }
                    if (!special.Contains(str[i + 1]))
                        str = (count > 1 && glCurent > 1) ? str.Insert(i + 1, "-") : str;
                    continue;
                }
                if (count > 1 && glCurent >= 1 && countGl >= 1) {
                    if (special.Contains(str[i + 1])) {
                        str = str.Insert(++i + 1, "-");
                        continue;
                    }
                    if (gl.Contains(str[i]) && !special.Contains(str[i + 2]) && sogl.Contains(str[i + 1]) && sogl.Contains(str[i + 2])) {
                        count++;
                        i++;
                    }
                    if (sogl.Contains(str[i]) && gl.Contains(str[i + 1])) {
                        continue;
                    }
                    str = str.Insert(i + 1, "-");
                }
                //str = (count > 1 && glCurent >= 1) ? str.Insert(i + 1, "-") : str;
            }
            return str;
        }
    }
}
