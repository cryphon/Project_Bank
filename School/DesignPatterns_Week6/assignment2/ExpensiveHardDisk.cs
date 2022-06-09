using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class ExpensiveHardDisk : IHardDisk
    {
        public void StoreData() => Console.WriteLine("storing data very quickly...");
    }
}
