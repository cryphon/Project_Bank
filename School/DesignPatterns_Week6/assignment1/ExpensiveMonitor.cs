using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class ExpensiveMonitor : IMonitor
    {
        public void Display() => Console.WriteLine("displaying stuff very nice...");
    }
}
