using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Week3
{
    public interface ITrainJourney
    {
        void AddObserver(ITrainDisplay controller);
        void RemoveObserver(ITrainDisplay controller);
        void NextStation();

    }
}
