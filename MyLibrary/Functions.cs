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
    }
}
