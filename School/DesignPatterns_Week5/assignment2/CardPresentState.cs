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
            Console.Write("Please enter your pincode: ");
            int pincode = int.Parse(Console.ReadLine());
            if (pincode == 1234)
            {
                Console.WriteLine("You have entered the correct pincode\n");
                _machine._currentState = new CorrectPinState(_machine);
            }
            else
                Console.WriteLine("You have entered the wrong pincode");
                
        }

        public void InsertCard() => Console.WriteLine("A card has been inserted already\n");

        public void RejectCard() 
        { 
            Console.WriteLine("Your card has been rejected\n");
            _machine._currentState = new NoCardState(_machine);
        }

        public void WithdrawCash() => Console.WriteLine("pincode has not been entered\n");
    }
}
