namespace assignment3
{
    public abstract class Display
    {
        public Song CurrentSong { get; set; }

        public Display(IObservable player) => player.Addobserver((IObserver)this);

        public virtual void Update(Song song) => this.CurrentSong = song;

        public abstract void DisplayData();
    }
}
