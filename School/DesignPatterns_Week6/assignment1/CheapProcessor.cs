using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class CheapProcessor : IProcessor
    {
        public void PerformOperation() => Console.WriteLine("performing operation not so quickly...");
    }
}
