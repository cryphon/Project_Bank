using System;

namespace assignment1
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
            HighBudgetShop highBudgetShop = new HighBudgetShop();
            IProcessor ExpensiveProcessor = highBudgetShop.CreateProcessor();
            IHardDisk ExpensiveHardDisk = highBudgetShop.CreateHardDisk();
            IMonitor ExpensiveMonitor = highBudgetShop.CreateMonitor();
            Computer ExpensiveComputer = highBudgetShop.AssembleComputer(ExpensiveProcessor, ExpensiveHardDisk, ExpensiveMonitor);
            ExpensiveComputer.Test();

            Console.WriteLine("\n[shop creating cheap computers]");
            LowBudgetShop lowBudgetShop = new LowBudgetShop();
            IProcessor CheapProcessor = lowBudgetShop.CreateProcessor();
            IHardDisk CheapHardDisk = lowBudgetShop.CreateHardDisk();
            IMonitor CheapMonitor = lowBudgetShop.CreateMonitor();
            Computer CheapComputer = lowBudgetShop.AssembleComputer(CheapProcessor, CheapHardDisk, CheapMonitor);
            CheapComputer.Test();

        }
    }
}
