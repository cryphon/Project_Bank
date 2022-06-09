using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class CheapHardDisk : IHardDisk
    {
        public void StoreData() => Console.WriteLine("storing data not so quickly...");
    }
}
