using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Week3
{
    public class TrainJourney : ITrainJourney
    {
        Station? _currentStation { get; set; }
        List<Station> _stations = new List<Station>() { new Station("Nijmegen", 3, new DateTime(), new DateTime()),
                                                        new Station("Arnhem Centraal", 11, new DateTime(), new DateTime()),
                                                        new Station("Ede-Wageningen", 3, new DateTime(), new DateTime()),
                                                        new Station("Heiloo", 1, new DateTime(), new DateTime()),
                                                        new Station("Castricum", 1, new DateTime(), new DateTime()),
                                                        new Station("Zaandam", 1, new DateTime(), new DateTime())};


        List<ITrainDisplay> _observers = new List<ITrainDisplay>();

        public int GetObserverCount() => _observers.Count;

        public void AddObserver(ITrainDisplay observer) => _observers.Add(observer);

        public void RemoveObserver(ITrainDisplay observer) => _observers.Remove(observer);

        public void NextStation()
        {
            if (_currentStation == _stations.Last()) { _stations.Reverse(); _currentStation = _stations[1]; }
            else
                _currentStation = _stations[_stations.IndexOf(_currentStation) + 1];
            NotifyObservers();
        }

        private void NotifyObservers()
        {
            foreach (TrainDisplay observer in _observers)
                observer.Update(_currentStation);
        }
    }
}
