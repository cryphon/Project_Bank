using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    public interface IObserver
    {
        void update(Song song);
        void DisplayData();
    }
}
