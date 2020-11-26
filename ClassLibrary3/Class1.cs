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
        public static void Run() // почему он статик ?
        {
            for (int i = 1; i <= 100; i++)
            {
                try
                {
                    Random r = new Random(); // var
                    int x = r.Next(1, 6);
                    if (x % 5 == 0) // что за стремная конструкция из if где switch case?
                    {
                        throw new Exception("I broke a toilet"); // это что вообще за логика страная? в задание же написано было что 3 метод КИАДЕТ ошибку а это что тут делает и вообще зачем это
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
                    Actions.Make_Exception(ex); // этого тут быть не должно тут должен вызываться логер который ошибку запишет

                }
                finally
                {
                    // этот блок ничего не делает и он не обязательный удали его
                }

            }
    
            // это вообще что то стремное и не понятно зачем
            /*Console.WriteLine("Продолжить(Ent) или закрыть консоль(Esc)?");

            var key = Console.ReadKey(); // зачем ?

            switch (key.Key)
            {
                case ConsoleKey.Enter:

                    {
                        string[] AllLogs = Logger.ReadAllLogs();
                        for (int i = 0; i < AllLogs.Length; i++)
                        {
                            Console.WriteLine(AllLogs[i]); текущий класс ВООБЩЕ не должен знать о CW о нем знает только ЛОГГЕР
                            
                        }
                        break;
                    }

                case ConsoleKey.Escape:
                    {
                        return;
                    }
            }*/

        }
    }
}
