namespace Ex.Fourth.Abstractions
{
    public interface IPlayable
    {
        void Play(string name);
        void Pause();
        void Stop();
    }
}
