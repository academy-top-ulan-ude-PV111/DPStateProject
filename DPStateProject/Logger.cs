using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPStateProject
{
    enum LoggerState
    {
        Console,
        File,
        Socket,
        ConsoleFile
    }

    interface ILoggerState
    {
        void Write(Logger logger);
        string Read(Logger logger);
    }

    class ConsoleLogger : ILoggerState
    {
        public string Message;
        public string Read(Logger logger)
        {
            Console.WriteLine($"Создание строки лога");
            Message = "15/10/22 - error file system";
            return Message;
        }

        public void Write(Logger logger)
        {
            Console.WriteLine($"Вывод на консоль {Message}");
        }
    }

    class FileLogger : ILoggerState
    {
        public string Message;
        public string Read(Logger logger)
        {
            Console.WriteLine($"Открываем файл");
            Console.WriteLine($"Читаем строку лога");
            Message = "15/10/22 - error file system";
            Console.WriteLine($"Закрываем файл");
            return Message;
        }

        public void Write(Logger logger)
        {
            Console.WriteLine($"Открываем файл");
            Console.WriteLine($"Записываем в файл");
            Console.WriteLine($"Закрываем файл");
        }
    }
    internal class Logger
    {
        public ILoggerState State { get; set; }
        public Logger(ILoggerState state)
        {
            State = state;
        }

        public void LogRead(string message) 
        {
            State.Read(this);
        }

        public void LogWrite()
        {
            State.Write(this);
        }


    }
}
