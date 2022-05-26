using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class ATMMachine : IATMState
    {
        decimal _amountInMachine { get; set; }

        public IATMState _currentState { get; set; }

        public decimal AmountInMachine { get { return _amountInMachine; } set { _amountInMachine = value; } }

        public ATMMachine(decimal cashAmount)
        {
            _amountInMachine = cashAmount;

            if (cashAmount > 0)
                _currentState = new NoCardState(this);
            else
                _currentState = new NoCashState(this);
               
        }

        public void InsertCard() => _currentState.InsertCard();

        public void RejectCard() => _currentState.RejectCard();

        public void EnterPincode() => _currentState.EnterPincode(); 

        public void WithdrawCash() => _currentState.WithdrawCash();
    }
}
