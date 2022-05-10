using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Week3
{
    public class TrainController : ITrainController
    {

        TrainJourney _journey { get; set; }

        public void NextStation() => _journey.NextStation();

        public TrainController(TrainJourney journey) => this._journey = journey;
    }
}
