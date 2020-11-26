using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ClassLibrary2
{
    public class Actions
    {
        public static void Start_method()
        {
            Logger logger = Logger.getInstance("Info","Youre here");

            string to_console = logger.Make_Massage();
            Console.WriteLine(to_console);
        }

        public static void Skipped_logic()
        {
            Logger logger = Logger.getInstance("Warning", "Skiping logic");
            string to_console = logger.Make_Massage();
            Console.WriteLine(to_console);
        }

        public static void Make_Exception(Exception ex)
        {
            Logger logger = Logger.getInstance("Exeption", ex.StackTrace);
            string to_console = logger.Make_Massage();
            Console.WriteLine(to_console);
        }
    }
}
