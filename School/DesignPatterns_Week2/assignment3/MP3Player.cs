using System;
using System.Collections.Generic;

namespace assignment3
{
    internal class MP3Player : IObservable
    {
        public Song CurrentSong { get; private set; }
        List<Song> SongList { get; set; }
        List<IObserver> _observers = new List<IObserver>();
        Random rnd = new Random(2);

        public MP3Player()
        {
            SongList = new List<Song>() { new Song("Papillon", "Editors", new TimeSpan(0, 5, 24)),
                                          new Song("Wish you were here", "Pink Floyd", new TimeSpan(0, 5, 39)),
                                          new Song("Dazed and Confused", "Led Zeppelin", new TimeSpan(0, 6, 26)),
                                          new Song("Billionaire", "Bruno Mars", new TimeSpan(0, 3, 31))};
        }

        public void NextSong()
        {
            Song rndSong = SongList[rnd.Next(SongList.Count)];
            CurrentSong = rndSong;

            foreach (IObserver observer in _observers)
            {
                observer.update(CurrentSong);
                observer.DisplayData();
            }
        }

        public void Addobserver(IObserver observer) => _observers.Add(observer);

        public void RemoveObserver(IObserver observer) => _observers.Remove(observer);
    }
}
