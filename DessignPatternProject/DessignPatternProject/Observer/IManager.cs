namespace DessignPatternProject.Observer
{
    public interface IManager
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }
}
