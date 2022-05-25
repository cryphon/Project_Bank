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
        IATMState _cardPresent { get; set; }
        IATMState _correctPincode { get; set; }
        IATMState _NoCard { get; set; }
        IATMState _NoCash { get; set; }

        public IATMState _currentState { get; set; }

        public decimal AmountInMachine { get { return _amountInMachine; }}

        public ATMMachine(decimal cashAmount)
        {
            _cardPresent = new CardPresentState(this);
            _correctPincode = new CorrectPinState(this);
            _NoCard = new NoCardState(this);
            _NoCash = new NoCashState(this);
            _amountInMachine = cashAmount;
               
        }

        public void InsertCard() => _currentState.InsertCard();

        public void RejectCard() => _currentState.RejectCard();

        public void EnterPincode() => _currentState.EnterPincode();

        public void WithdrawCash() => _currentState.WithdrawCash();
    }
}
