using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary1
{
    public class Logger
    {
        private static string file_path = "Logger.TXT";
        public string Type;
        public string Message;


        private static Logger instance;

        private Logger()
        { }

        public Logger(string type)
        {
            Type = type;
        }

        public Logger(string type, string message)
        {
            Type = type;
            Message = message;
        }

        public static Logger getInstance(string type, string message)
        {

            if (instance == null)
            {
                instance = new Logger();
            }
            instance.Type = type;
            instance.Message = message;

            return instance;
        }

        public string Make_Massage()
        {
            string massage = "{ " + Type + " }: { " + Message + " }";
            File.AppendAllText(file_path, massage + "\n");
            return massage;
        }

        public static string[] ReadAllLogs()
        {
            string[] all_logs = File.ReadAllLines(file_path);
            return all_logs;
        }


    }

}