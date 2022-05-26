using System;

namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            ATMMachine _machine = new ATMMachine(2000);
            string input;
            do
            {
                Console.Write("Please enter your command: ");
                Console.ForegroundColor = ConsoleColor.Green;
                input = Console.ReadLine();
                Console.ResetColor();

                if (input == "stop")
                    return;
                switch (input)
                {
                    case "insert card":
                        _machine.InsertCard();
                        break;
                    case "reject card":
                        _machine.RejectCard();
                        break;
                    case "enter pincode":
                        _machine.EnterPincode();
                        break;
                    case "withdraw cash":
                        _machine.WithdrawCash();
                        break;
                    default:
                        Console.WriteLine("entered unknown command\n");
                        break;
                }
            } while (input != "stop");
        }
    }
}
