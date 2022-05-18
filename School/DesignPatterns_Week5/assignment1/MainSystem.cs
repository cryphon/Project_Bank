using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class MainSystem
    {
        SubSystem _subSystem;
        Logger _logger;
        public MainSystem() { _subSystem = new SubSystem(); _logger = Logger.GetInstance(); }

        public void DoSomeMainWork()
        {
            _logger.Log("MainSystem", "doing some main work");
            _subSystem.DoSomeWork();
            _subSystem.DoSomeMoreWork();
        }

    }
}
