using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class Computer
    {
        IProcessor Processor { get; set; }
        IHardDisk Disk { get; set; }
        IMonitor Monitor { get; set; }

        public Computer(IProcessor p, IHardDisk hd, IMonitor m)
        {
            Processor = p;
            Disk = hd;
            Monitor = m;
        }
        public void Test() 
        {
            Processor.PerformOperation();
            Disk.StoreData();
            Monitor.Display();
        }
    }
}
