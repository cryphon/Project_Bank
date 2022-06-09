using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class ExpensiveProcessor : IProcessor
    {
        public void PerformOperation() => Console.WriteLine("performing operation very quickly...");
    }
}
