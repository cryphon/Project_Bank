using System;

namespace assignment1
{
    public abstract class BigDataLoader
    {
        public void ETL()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[ETL-proces started]");
            Console.ResetColor();
            ExtractData(); //extract
            TransformData(); //transform
            LoadTransformedData(); //load
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[ETL-proces finished]\n");
            Console.ResetColor();
        }

        public abstract void ExtractData();
        public abstract void TransformData();
        public void LoadTransformedData() => Console.WriteLine("loading transformed data...");
    }
}
