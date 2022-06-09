using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public abstract class Shop
    {
        public Computer AssembleComputer(IProcessor p, IHardDisk hd, IMonitor m) => new Computer(p, hd, m);

        public abstract IProcessor CreateProcessor();

        public abstract IHardDisk CreateHardDisk();

        public abstract IMonitor CreateMonitor();
    }
}
