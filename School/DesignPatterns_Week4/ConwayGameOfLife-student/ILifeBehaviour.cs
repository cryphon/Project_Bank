using System;
using System.Collections.Generic;
using System.Text;

namespace ConwayGameOfLife
{
    public interface ILifeBehaviour
    {
        public bool CellShouldLive(bool livingcell, int neighbourCount);
    }
}
