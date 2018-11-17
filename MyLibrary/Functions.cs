using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    static public class Functions
    {
        /// <summary>
        /// Меняет местами ссылки на объекты одинакового типа.
        /// </summary>
        /// <typeparam name="T">Класс объектов</typeparam>
        /// <param name="first"></param>
        /// <param name="second"></param>
        static public void Swap<T>(ref T first, ref T second)
        {
            T temp;
            temp = first;
            first = second;
            second = temp;
        }


        /// <summary>
        /// Удаляет из массива строк все элементы, являющиеся пустыми строками.
        /// </summary>
        /// <param name="strs"></param>
        static public void ArrayDelEmpty(ref string[] strs)
        {
            int count = 0;
            foreach (string str in strs) {
                if (str == "") count++;
            }
            string[] result = new string[strs.Length - count];
            int i = 0, j = 0;
            while (j < result.Length) {
                if (strs[i] != "") {
                    result[j++] = strs[i];
                }
                i++;
            }
            strs = result;
        }

        /// <summary>
        /// Удаляет из строки все лишние пробелы.
        /// </summary>
        /// <param name="str"></param>
        static public void ExtraSpaces(ref string str){
            int pos;
            str.Trim();
            do {
                pos = str.IndexOf("  ");
                if (pos > 0) str = str.Remove(pos, 2).Insert(pos, " ");
            } while (pos > 0);
        }
    }
}
