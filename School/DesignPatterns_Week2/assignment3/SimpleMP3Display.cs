using System;

namespace assignment3
{
    public class SimpleMP3Display : Display, IObserver
    {

        public SimpleMP3Display(IObservable player)
            : base(player) { }

        public override void DisplayData() => Console.WriteLine($"Simple display: {CurrentSong.Artist} - {CurrentSong.Name}");

        public override void Update(Song song)
        {
            CurrentSong = song;
            DisplayData();
        }
    }
}
