using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    static public class ConsoleDialog
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        static public bool YN_Dialog(string question)
        {
            Console.WriteLine(question + "(Y/N)?");
            while (true) {
                char key = Char.ToUpper(Console.ReadKey(true).KeyChar);
                if (key == 'Y' || key == 'Н')
                    return true;
                if (key == 'N' || key == 'Т')
                    return false;
                Console.WriteLine("Нажмите Y или N.");
            }
        }

        /// <summary>
        /// Выводит запрос на экран и записывает введенное значение в result. Возвращает <c>true</c> если введенная строка не пуста.
        /// </summary>
        /// <param name="message">Содержет запрос, каторый будет задан пользователь</param>
        /// <param name="result"></param>
        /// <returns></returns>
        static public bool ReadValue(string message, out string result)
        {
            Console.WriteLine(message);
            result = Console.ReadLine();
            if (result == "") return false;
            return true;
        }

        /// <summary>
        /// Выводит запрос на экран и разбивает введенную строку на подстроки в зависимости от символов разделителя. 
        /// Возвращает <c>true</c> если введенная строка не пуста.
        /// </summary>
        /// <param name="message">Содержет запрос, каторый будет задан пользователь</param>
        /// <param name="result"></param>
        /// <returns></returns>
        static public bool ReadValue(string message, out string[] result, params char[] separator)
        {
            Console.WriteLine(message);
            result = Console.ReadLine().Split(separator);
            if (result.Length == 0) return false;
            return true;
        }

        /// <summary>
        /// Выводит запрос на экран и записывает введенное значение в result в формате <c>char[]</c>. Возвращает <c>true</c> если введенная строка не пуста.
        /// </summary>
        /// <param name="message">Содержет запрос, каторый будет задан пользователь</param>
        /// <param name="result"></param>
        /// <returns></returns>
        static public bool ReadValue(string message, out char[] result)
        {
            Console.WriteLine(message);
            result = Console.ReadLine().ToCharArray();
            if (result.Length == 0) return false;
            return true;
        }

        /// <summary>
        /// Выводит запрос на экран, затем преобразует введенное значение в целое 32-х разряное число записывает его в result. 
        /// Возвращает значение, указывающее, еспешно ли выполнено преобразование.
        /// </summary>
        /// <param name="message">Содержет запрос, каторый будет задан пользователь</param>
        /// <param name="result"></param>
        /// <returns></returns>
        static public bool ReadValue(string message, out int result)
        {
            Console.WriteLine(message);
            return int.TryParse(Console.ReadLine(), out result);
        }

        /// <summary>
        /// Выводит запрос на экран, затем преобразует введенное значение в целое число типа byte записывает его в result. 
        /// Возвращает значение, указывающее, еспешно ли выполнено преобразование.
        /// </summary>
        /// <param name="message">Содержет запрос, каторый будет задан пользователь</param>
        /// <param name="result"></param>
        /// <returns></returns>
        static public bool ReadValue(string message, out byte result)
        {
            Console.WriteLine(message);
            return byte.TryParse(Console.ReadLine(), out result);
        }

        /// <summary>
        /// Выводит запрос на экран, затем преобразует введенное значение в число двойной точности с плавающей точкой записывает его в result. 
        /// Возвращает значение, указывающее, еспешно ли выполнено преобразование.
        /// </summary>
        /// <param name="message">Содержет запрос, каторый будет задан пользователь</param>
        /// <param name="result"></param>
        /// <returns></returns>
        static public bool ReadValue(string message, out double result)
        {
            Console.WriteLine(message);
            return double.TryParse(Console.ReadLine(), out result);
        }

        /// <summary>
        /// Выводит запрос на экран, затем преобразует введенное значение в число одинарной точности с плавающей точкой записывает его в result. 
        /// Возвращает значение, указывающее, еспешно ли выполнено преобразование.
        /// </summary>
        /// <param name="message">Содержет запрос, каторый будет задан пользователь</param>
        /// <param name="result"></param>
        /// <returns></returns>
        static public bool ReadValue(string message, out float result)
        {
            Console.WriteLine(message);
            return float.TryParse(Console.ReadLine(), out result);
        }
        
        /// <summary>
        /// Приостанавливает программу до тех пор, пока не будет нажата клавиша.
        /// </summary>
        static public void HoldToKeyPress()
        {
            Console.WriteLine("Нажмите любую кнопку...");
            Console.ReadKey(true);
        }

        /// <summary>
        /// Приостанавливает программу до тех пор, пока не будет нажата клавиша.
        /// </summary>
        /// <param name="message">Сообщение о причине остановки.</param>
        static public void HoldToKeyPress(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("Нажмите любую кнопку...");
            Console.ReadKey(true);
        }
    }
}
