using System;
using System.IO;
using System.Threading;

namespace lab_8
{
    class Program
    {

        static private String helpFile = "..\\..\\help.txt";

        static private bool argAll = false;
        static private bool argRefresh = false;
        static private bool argSkeep = false;
        static private bool argHelp = false;

        static private int delay = 1000;

        static void Main(string[] args)
        {
            int robots = -1, years = -1;
            if (args.Length != 0)
            {
                int count = 0;
                foreach (String str in args)
                {
                    switch (count)
                    {
                        case 0: 
                            if (str.ToUpper() == "/H")
                            {
                                GetConsoleHelp(helpFile);
                                return;
                            }
                            if(!int.TryParse(str, out robots) || robots <= 0)
                            {
                                InputError();
                                return;
                            }
                            break;
                        case 1:
                            if(str.ToUpper() == "/H")
                            {
                                GetConsoleHelp(helpFile);
                                return;
                            }
                            if (!int.TryParse(str, out years) || years <= 0)
                            {
                                InputError();
                                return;
                            }
                            break;
                        default:
                            if (!GetArg(str))
                            {
                                InputError();
                                return;
                            }
                            if (argHelp) return;
                            break;
                    }
                    count++;
                    
                }
            }

            if(robots == -1)
            {
                Console.WriteLine("Введите изначальное колличество роотов");
                if (!int.TryParse(Console.ReadLine(), out robots) || robots <= 0)
                {
                    InputError();
                    return;
                }
            }
            if (years == -1)
            {
                Console.WriteLine("Введите колличество лет");
                if (!int.TryParse(Console.ReadLine(), out years) || years <= 0)
                {
                    InputError();
                    return;
                }
            }

            Robots(robots, years);
            if (args.Length == 0) Console.ReadKey();

        }

        static void Robots(int robots, int years)
        {
            if (robots < 3)
            {
                Console.WriteLine("Слишком мало роботов");
                return;
            }
            int[] age = new int[3] { robots, 0, 0 };

            int robots0 = 0, robots1 = 0, robots2 = 0;

            for (int i = 1; i <= years; i++)
            {
                if (argRefresh) Console.Clear();

                if (argAll)
                {
                    robots0 = age[0];
                    robots1 = age[1];
                    robots2 = age[2];
                }

                robots = age[0] + age[1] + age[2];

                age[2] = age[1];
                age[1] = age[0];
                age[0] = Production(robots);

                if (argSkeep) continue;

                Console.WriteLine();
                Console.WriteLine("Год " + i);
                Console.WriteLine("Общее число роботов: " + robots);
                if (argAll)
                {
                    Console.WriteLine("                  Число новых роботов:  " + robots0);
                    Console.WriteLine(" Число роботов работающих больше года:  " + robots1);
                    Console.WriteLine("Число роботов работающих больше 2 лет:  " + robots2);
                    Console.WriteLine("\n             Роботов было произведено:  " + age[0]);
                }

                Console.WriteLine("----------------------------------------");

                if (argRefresh)
                {
                    Thread.Sleep(delay);
                }
                
            }
            if (argSkeep)
            {
                Console.WriteLine("Год " + years);
                Console.WriteLine("Общее число роботов: " + robots);
            }
            
        }

        static int Production(int robots)
        {
            if (robots < 3) return 0;
            if (robots < 5) return 5;

            int team5 = robots/5, team3 = (robots - team5*5)/3;
            while (team5*5+team3*3 != robots)
            {
                team5--;
                team3 = (robots - team5*5) / 3;
            }
            return team5 * 9 + team3 * 5;

        }

        private static void InputError()
        {
            Console.WriteLine("Ошибка ввода\nНажмите любую кнопку...");
            Console.ReadKey();
        }

        static void GetConsoleHelp(String filename)
        {
            try
            {
                StreamReader file = new StreamReader(filename);
                String str = file.ReadLine();
                while(str != null)
                {
                    Console.WriteLine(str);
                    str = file.ReadLine();
                }
                file.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error!" + e.Message + "\nНажмите любую кнопку");
                Console.ReadKey();
            }
        }

        static bool GetDelay(String arg)
        {
            if (arg.IndexOf('=') == -1) return true;
            arg = arg.Substring(arg.IndexOf('=') + 1);
            return int.TryParse(arg, out delay);

        }

        static bool GetArg(String arg)
        {
            switch (arg.ToUpper().Substring(0, 2))
            {
                case "/A":
                    argAll = true;
                    return true;
                case "/R":
                    if (argSkeep) return false;
                    argRefresh = true;
                    GetDelay(arg);
                    return true;
                case "/S":
                    if (argRefresh) return false;
                    argSkeep = true;
                    return true;
                case "/H":
                    GetConsoleHelp(helpFile);
                    argHelp = true;
                    return true;
                default:
                    return false;
            }
        }
    }
}
