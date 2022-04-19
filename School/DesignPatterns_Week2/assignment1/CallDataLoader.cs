using System;

namespace assignment1
{
    internal class CallDataLoader : BigDataLoader
    {
        public override void ExtractData() => Console.WriteLine("extracting call data...");

        public override void TransformData() => Console.WriteLine("transforming call data...");
    }
}
