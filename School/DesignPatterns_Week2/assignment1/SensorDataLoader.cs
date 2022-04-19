using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class SensorDataLoader : BigDataLoader
    {
        public override void ExtractData() => Console.WriteLine("extracting sensor data...");

        public override void TransformData() => Console.WriteLine("transforming sensor data...");
    }
}
