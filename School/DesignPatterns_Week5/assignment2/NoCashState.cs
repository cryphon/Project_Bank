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


        public NoCashState(ATMMachine machine)
        {
            _machine = machine;
            _machine._currentState = this;
        }

        public void EnterPincode()
        {
            throw new NotImplementedException();
        }

        public void InsertCard()
        {
            throw new NotImplementedException();
        }

        public void RejectCard()
        {
            throw new NotImplementedException();
        }

        public void WithdrawCash()
        {
            throw new NotImplementedException();
        }
    }
}
