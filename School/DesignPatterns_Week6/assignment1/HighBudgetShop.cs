using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class HighBudgetShop : Shop
    {
        public override IHardDisk CreateHardDisk() => new ExpensiveHardDisk();

        public override IMonitor CreateMonitor() => new ExpensiveMonitor();

        public override IProcessor CreateProcessor() => new ExpensiveProcessor();
    }
}
