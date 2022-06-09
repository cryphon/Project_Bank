using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class LowBudgetShop : Shop
    {
        public override IHardDisk CreateHardDisk() => new CheapHardDisk();

        public override IMonitor CreateMonitor() => new CheapMonitor();

        public override IProcessor CreateProcessor() => new CheapProcessor();
    }
}
