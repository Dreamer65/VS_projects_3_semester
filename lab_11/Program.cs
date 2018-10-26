using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join("\n", args)+"\n");
            Console.WriteLine(BigSum(args));
            Console.WriteLine(BigDiff(args));
        }

        static void Swap<T>(ref T first, ref T second) {
            T temp;
            temp = first;
            first = second;
            second = temp;
        }

        static string TrimToNumber(string str, char separator)
        {
            str = str.TrimEnd('0');
            str = str.TrimEnd(separator);
            str = str.TrimStart('0');
            if (str == "") return "0";
            if (str[0] == separator) return "0" + str;
            return str;
        }
        static string BigSum(params string[] numbers) 
        {
            if (numbers.Length == 0) return "0";
            if (numbers.Length == 1) return numbers[0];
            string result = numbers[0];
            for (int i = 1; i < numbers.Length; i++) {
                result = BigSum(',', result, numbers[i]);
            }
            return result;
        }

        static string BigSum(char separator, params string[] numbers)
        {
            if (numbers.Length == 0) return "0";
            if (numbers.Length == 1) return numbers[0];
            string result = numbers[0];
            for (int i = 1; i < numbers.Length; i++) {
                result = BigSum(separator, result, numbers[i]);
            }
            return result;
        }

        static string BigSum(char separator, string number1, string number2) // Основная реализация
        {
            number1 = number1.Trim();
            number2 = number2.Trim();
            if (number1 == "" && number2 == "") return "0";
            if (number1 == "") return number2;
            if (number2 == "") return number1;

            string sign = "";
            if ((number1[0] == '-' && number2[0] != '-')) {
                return BigDiff(separator, number2, number1.Substring(1));
            }
            if ((number1[0] != '-' && number2[0] == '-')) {
                return BigDiff(separator, number1, number2.Substring(1));
            }

            if (number1[0] == '-' && number2[0] == '-'){
                sign = "-";
                number1 = number1.Substring(1);
                number2 = number2.Substring(1);
            }

            int dot1 = number1.IndexOf(separator), dot2 = number2.IndexOf(separator);
            if (dot1 != -1 || dot2 != -1){
                if (dot1 == -1){
                    dot1 = number1.Length;
                    number1 += separator;
                }
                if (dot2 == -1){
                    dot2 = number2.Length;
                    number2 += separator;
                }
                int add0 = Math.Abs((number1.Length - dot1) - (number2.Length - dot2));
                if (add0 != 0)
                    if (number1.Length - dot1 > number2.Length - dot2)
                        number2 = number2.PadRight(number2.Length + add0, '0');
                    else
                        number1 = number1.PadRight(number1.Length + add0, '0');
            }
            else {
                number1 += separator;
                number2 += separator;
            }
            number1 = number1.PadLeft(number2.Length, '0');
            number2 = number2.PadLeft(number1.Length, '0');

            string result = "";
            int buf = 0;
            for (int i = number1.Length-1; i >= 0; i--){
                if (number1[i] == separator){
                    result = separator + result;
                    continue;
                }
                buf += int.Parse(number1[i].ToString()) + int.Parse(number2[i].ToString());
                result = (buf % 10) + result;
                buf = (buf >= 10) ? 1 : 0;
            }
            if (buf != 0) result = buf + result;

            return sign + TrimToNumber(result, separator);
        }

        static string BigDiff(params string[] numbers)
        {
            if (numbers.Length == 0) return "0";
            if (numbers.Length == 1) return numbers[0];
            string result = numbers[0];
            for (int i = 1; i < numbers.Length; i++) {
                result = BigDiff(',', result, numbers[i]);
            }
            return result;
        }

        static string BigDiff(char separator, params string[] numbers)
        {
            if (numbers.Length == 0) return "0";
            if (numbers.Length == 1) return numbers[0];
            string result = numbers[0];
            for (int i = 1; i < numbers.Length; i++) {
                result = BigDiff(separator, result, numbers[i]);
            }
            return result;
        }

        static string BigDiff(char separator, string number1, string number2) // Основная реализация
        { 
            number1 = number1.Trim();
            number2 = number2.Trim();
            if (number1 == "" && number2 == "") return "0";
            if (number1 == "") return (number2[0] == '-') ? number2.Substring(1) : "-" + number2;
            if (number2 == "") return number1;

            string sign = "";
            if ((number1[0] == '-' && number2[0] != '-')){
                return BigSum(separator, number1, "-" + number2);
            }
            if ((number1[0] != '-' && number2[0]  == '-')) {
                return BigSum(separator, number1, number2.Substring(1));
            }

            if (number1[0] == '-' && number2[0] == '-') {
                sign = "-";
                number1 = number1.Substring(1);
                number2 = number2.Substring(1);
            }

            int dot1 = number1.IndexOf(separator), dot2 = number2.IndexOf(separator);
            if (dot1 != -1 || dot2 != -1) {
                if (dot1 == -1) {
                    dot1 = number1.Length;
                    number1 += separator;
                }
                if (dot2 == -1) {
                    dot2 = number2.Length;
                    number2 += separator;
                }
                int add0 = Math.Abs((number1.Length - dot1) - (number2.Length - dot2));
                if (add0 != 0)
                    if (number1.Length - dot1 > number2.Length - dot2)
                        number2 = number2.PadRight(number2.Length + add0, '0');
                    else
                        number1 = number1.PadRight(number1.Length + add0, '0');
            }
            else {
                number1 += separator;
                number2 += separator;
            }
            number1 = number1.PadLeft(number2.Length, '0');
            number2 = number2.PadLeft(number1.Length, '0');

            bool chengeSign = false;
            int comp = String.Compare(number1, number2);
            if (comp == 0) return "0";
            if (comp < 0) {
                Swap(ref number1, ref number2);
                chengeSign = true;
            }

            string result = "";
            int buf = 0, a, b;
            for (int i = number1.Length - 1; i >= 0; i--) {
                if (number1[i] == separator) {
                    result = separator + result;
                    continue;
                }
                a = int.Parse(number1[i].ToString())+buf;
                b = int.Parse(number2[i].ToString());
                buf  = (a - b >= 0) ? 0 : -1;
                result = ((a - b >= 0) ? a - b : 10 + a - b) + result;
            }

            return ((chengeSign) ? ((sign == "") ? "-" : "") : sign) + TrimToNumber(result, separator);
        }


    }
}
