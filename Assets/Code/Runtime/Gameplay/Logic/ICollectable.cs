namespace Code.Runtime.Gameplay.Logic
{
    public interface ICollectable
    {
        bool IsCollected { get; }
        public void Collect(Collector collector);
    }
}