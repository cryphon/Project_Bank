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

        IATMState _currentState { get; set; }
        CardPresentState _CardPresentstate;
        NoCardState _NoCardState;
        CorrectPinState _CorrectPinState;
        NoCashState _NoCashState;

        public decimal AmountInMachine { get { return _amountInMachine; } set { _amountInMachine = value; } }

        public ATMMachine(decimal cashAmount)
        {
            _amountInMachine = cashAmount;
            _CardPresentstate = new CardPresentState(this);
            _NoCardState = new NoCardState(this);
            _CorrectPinState = new CorrectPinState(this);
            _NoCashState = new NoCashState(this);

            if (cashAmount > 0)
                _currentState = new NoCardState(this);
            else
                _currentState = new NoCashState(this);
               
        }

        public IATMState GetCardPresentState() => _CardPresentstate;
        public IATMState GetNoCardState() => _NoCardState;
        public IATMState GetCorrectPinState() => _CorrectPinState;
        public IATMState GetNoCashState() => _NoCashState;

        public void InsertCard() => _currentState.InsertCard();

        public void RejectCard() => _currentState.RejectCard();

        public void EnterPincode() => _currentState.EnterPincode(); 

        public void WithdrawCash() => _currentState.WithdrawCash();

        public void SetCurrentState(IATMState state) => _currentState = state;
    }
}
