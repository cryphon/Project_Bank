using System;

namespace assignment3
{
    public class FancyMP3Display : Display, IObserver
    {
        public FancyMP3Display(IObservable player)
            : base(player) { }

        public override void DisplayData() => Console.WriteLine($"Fancy Display: {CurrentSong.Name} by {CurrentSong.Artist} ({CurrentSong.Duration.ToString("mm\\:ss")})\n");
    }
}