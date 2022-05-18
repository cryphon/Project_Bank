using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class Logger
    {
        int _NumberOfLines = 0;
        private static Logger _instance;

        private Logger() { }
        
        public static Logger GetInstance()
        {
            if (_instance == null)
                _instance = new Logger();
            return _instance;
        }
        public void Log(string program, string action) => Console.WriteLine($"{++_NumberOfLines} - [{program}] {action}");

    }
}
