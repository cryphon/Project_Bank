using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    public abstract class Display
    {
        public Song CurrentSong { get; set; }

        public Display(IObservable player) => player.Addobserver((IObserver)this);

        public void update(Song song) => this.CurrentSong = song;

        public abstract void DisplayData();
    }
}
