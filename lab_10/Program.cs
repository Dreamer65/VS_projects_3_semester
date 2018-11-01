using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDate date = new MyDate();
            MyDate con = new MyDate();
            do {
                con.Date = Console.ReadLine();
                Console.WriteLine(date - con);
                Console.ReadKey();
            } while (date != con);
        }
    }
}
