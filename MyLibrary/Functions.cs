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
        /// Меняет местами ссылки на объекты одинакового типа
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
    }
}
