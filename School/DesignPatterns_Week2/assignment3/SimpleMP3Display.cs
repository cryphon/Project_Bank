using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    public class SimpleMP3Display : Display,IObserver
    {

        public SimpleMP3Display(IObservable player)
            : base(player) { }

        public override void DisplayData() => Console.WriteLine($"Simple display: {CurrentSong.Artist} - {CurrentSong.Name}");
    }
}
