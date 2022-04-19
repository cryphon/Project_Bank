using System.Collections.Generic;

namespace assignment1
{
    internal class BatchProcessor
    {
        List<BigDataLoader> _batches = new List<BigDataLoader>();

        public void AddDataLoader(BigDataLoader loader) => _batches.Add(loader);

        public void ProcessBatches()
        {
            foreach (var batch in _batches)
                batch.ETL();
        }
    }
}
