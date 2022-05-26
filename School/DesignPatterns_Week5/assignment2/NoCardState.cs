using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class NoCardState : IATMState
    {
        ATMMachine _machine;

        public NoCardState(ATMMachine machine)
        {
            _machine = machine;
            _machine._currentState = this;
        }
        public void EnterPincode() => Console.WriteLine("No card has been inserted\n");

        public void InsertCard() 
        { 
            Console.WriteLine("Card has been inserted\n"); 
            _machine._currentState = new CardPresentState(_machine);
        }

        public void RejectCard() => Console.WriteLine("No card has been inserted\n");

        public void WithdrawCash() => Console.WriteLine("No card has been inserted\n");
    }
}
