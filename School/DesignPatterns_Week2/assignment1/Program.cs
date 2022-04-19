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
            BatchProcessor processor = new BatchProcessor();
            processor.AddDataLoader(new CallDataLoader());
            processor.AddDataLoader(new TwitterDataLoader());
            processor.AddDataLoader(new SensorDataLoader());
            processor.ProcessBatches();
        }
    }
}
