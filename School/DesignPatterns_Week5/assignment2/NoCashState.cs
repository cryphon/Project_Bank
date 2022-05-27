using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    internal class NoCashState : IATMState
    {
        ATMMachine _machine;

        public NoCashState(ATMMachine machine) => _machine = machine;

        public void EnterPincode() => Console.WriteLine("Not enough cash available in machine\n");

        public void InsertCard() => Console.WriteLine("Not enough cash available in machine\n");

        public void RejectCard() => Console.WriteLine("Not enough cash available in machine\n");

        public void WithdrawCash() => Console.WriteLine("Not enough cash available in machine\n");
    }
}
