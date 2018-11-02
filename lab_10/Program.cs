using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDate date = new MyDate();
            MyDate con;
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            int tmp;
            try {
                do {
                    tmp = Convert.ToInt32(Console.ReadLine());
                    sw.Restart();
                        con = tmp + date;
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedMilliseconds.ToString());
                    Console.WriteLine(con.Date);
                    Console.WriteLine(con - date);
                } while (date != con);
            }
            catch {
                Console.WriteLine("Error");
                Console.ReadKey();
            }
        }
    }
}
