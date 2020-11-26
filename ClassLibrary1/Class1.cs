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
        private static string file_path = "Logger.TXT"; // ты собираешься потом это менять или же название всегда будет неизменым 
        //если не изменным то почему не const и почему это static. Что за упоротое название?) тут так не принято через _
        public string Type; // публичное поле? к черту инкапсуляцию
        public string Message; // опять же 


        private static Logger instance; 

        private Logger()
        { }

        // что это !?)) если ты сделал публичные конструкторы то где же тогда синглтон? 
        //ты же везде можешь сделать var a = new Logger("sdf"); и таких кучу наклепать
       /* public Logger(string type)
        {
            Type = type;
        }

        public Logger(string type, string message)
        {
            Type = type;
            Message = message;
        } */

        //тест комент
        
        //этот объект ты создашь ОДИН раз потом когда будешь вызывать эту строчку то 
        // instance.Type = type;
        //    instance.Message = message;
        // уже не выполниться
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
            // Логер пишет в консоль а не в  файл 
            
            // при этом Дополнительно сохраняет весь текст для отдачи
            // но писать в диск не скажу что это противоречит условиям но лучше это делать в памяти в тот же стринг билдер писать
            string massage = "{ " + Type + " }: { " + Message + " }";
            File.AppendAllText(file_path, massage + "\n");
            return massage;
        }

        public static string[] ReadAllLogs() // зачему это статик ? да и зачем метод когда проще сделать свойство на возврат 
        {
            //почему не var ?
            // не называй так переменные используй camelCase
            string[] all_logs = File.ReadAllLines(file_path);
            return all_logs;
        }


    }

}
