using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    public interface IObservable
    {
        void Addobserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NextSong();
    }
}
