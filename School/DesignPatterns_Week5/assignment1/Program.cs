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
            Logger logger = Logger.GetInstance();
            logger.Log("Program", "starting");
            MainSystem mainSystem = new MainSystem();
            mainSystem.DoSomeMainWork();
            logger.Log("Program", "finishing");

        }
    }
}
