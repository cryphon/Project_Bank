using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class LowBudgetFactory : IFactory
    {
        public IHardDisk CreateHardDisk() => new CheapHardDisk();

        public IMonitor CreateMonitor() => new CheapMonitor();

        public IProcessor CreateProcessor() => new CheapProcessor();
    }
}
