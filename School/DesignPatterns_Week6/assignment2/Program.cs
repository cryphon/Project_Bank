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
            Console.WriteLine("[shop creating expensive computers]");
            HighBudgetFactory highBudgetFactory = new HighBudgetFactory();
            ComputerShop highBudgetShop = new ComputerShop(highBudgetFactory);
            Computer ExpensiveComputer = highBudgetShop.AssembleComputer();
            ExpensiveComputer.Test();
            
            Console.WriteLine("\n[shop creating cheap computers]");
            LowBudgetFactory lowBudgetFactory = new LowBudgetFactory();
            ComputerShop lowBudgetShop = new ComputerShop(lowBudgetFactory);
            Computer CheapComputer = lowBudgetShop.AssembleComputer();
            CheapComputer.Test();
        }
    }
}
