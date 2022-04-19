using System;

namespace assignment1
{
    internal class SensorDataLoader : BigDataLoader
    {
        public override void ExtractData() => Console.WriteLine("extracting sensor data...");

        public override void TransformData() => Console.WriteLine("transforming sensor data...");
    }
}
