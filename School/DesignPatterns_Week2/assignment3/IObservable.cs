namespace assignment3
{
    public interface IObservable
    {
        void Addobserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NextSong();
    }
}
