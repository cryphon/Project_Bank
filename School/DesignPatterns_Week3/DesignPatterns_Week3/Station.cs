using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Week3
{
    public class Station
    {
        public string? _name { get; set; }
        public int _arrivalTrack { get; set; }
        DateTime? _arrivalTime { get; set; }
        DateTime? _departureTime { get; set; }


        public Station(string name, int track, DateTime arrival, DateTime depart)
        {
            this._name = name;
            this._arrivalTrack = track;
            this._arrivalTime = arrival;
            this._departureTime = depart;
        }

    }
}
