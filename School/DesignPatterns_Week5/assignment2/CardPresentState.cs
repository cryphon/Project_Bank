using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    internal class CardPresentState :IATMState
    {
        ATMMachine _machine;

        public CardPresentState(ATMMachine machine)
        {
            _machine = machine;
            _machine._currentState = this;
        }

        public void EnterPincode()
        {
            Console.WriteLine("Please enter your pincode: ");
            int pin = int.Parse(Console.ReadLine());

        }

        public void InsertCard() => Console.WriteLine("A card has been inserted already");

        public void RejectCard() => Console.WriteLine("Card has been rejected");

        public void WithdrawCash()
        {
            Console.Write("Please eneter amount of cash: ");
            decimal cashAmount = decimal.Parse(Console.ReadLine());

            if (cashAmount <= _machine.AmountInMachine)
                Console.WriteLine($"{cashAmount} withdrawn from machine");
            else
                Console.WriteLine("Not enough cash available in machine");
        }
    }
}
