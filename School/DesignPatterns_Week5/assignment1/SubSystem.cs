using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class SubSystem
    {
        Logger _logger;
        public SubSystem() { _logger = Logger.GetInstance(); }

        public void DoSomeWork() => _logger.Log("SubSystem", "doing some work");

        public void DoSomeMoreWork() => _logger.Log("SubSystem", "doing some more work");
    }
}
