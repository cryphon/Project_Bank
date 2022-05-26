using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class CorrectPinState : IATMState
    {
        ATMMachine _machine;
        public CorrectPinState(ATMMachine machine)
        {
            _machine = machine;
            _machine._currentState = this;
        }

        public void EnterPincode() => Console.WriteLine("Pincode has already been entered\n");

        public void InsertCard() => Console.WriteLine("Card has been inserted already\n");

        public void RejectCard()
        {
            Console.WriteLine("Your card has been rejected\n");
            _machine._currentState = new NoCardState(_machine);
        }

        public void WithdrawCash()
        {
            Console.Write("Please enter amount of cash: ");
            decimal cashAmount = decimal.Parse(Console.ReadLine());

            if (cashAmount <= _machine.AmountInMachine)
            {
                Console.WriteLine($"{cashAmount} withdrawn from machine");
                _machine.AmountInMachine -= cashAmount;
            }         
            else
            {
                Console.WriteLine("Not enough cash available in machine\n");
                _machine._currentState = new NoCashState(_machine);
            }
            RejectCard();
        }
    }
}
