using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ClassLibrary1;
using ClassLibrary2;

namespace ClassLibrary3
{
    public class Starter
    {
        public static void Run()
        {
            for (int i = 1; i <= 100; i++)
            {
                try
                {
                    Random r = new Random();
                    int x = r.Next(1, 6);
                    if (x % 5 == 0)
                    {
                        throw new Exception("I broke a toilet");
                    }
                    else if (x % 3 == 0)
                    {
                        Actions.Skipped_logic();
                    }
                    else
                    {
                        Actions.Start_method();
                    }

                }
                catch (Exception ex)
                {
                    Actions.Make_Exception(ex);

                }
                finally
                {

                }

            }

            Console.WriteLine("Продолжить(Ent) или закрыть консоль(Esc)?");

            var key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.Enter:

                    {
                        string[] AllLogs = Logger.ReadAllLogs();
                        for (int i = 0; i < AllLogs.Length; i++)
                        {
                            Console.WriteLine(AllLogs[i]);
                        }
                        break;
                    }

                case ConsoleKey.Escape:
                    {
                        return;
                    }
            }

        }
    }
}
