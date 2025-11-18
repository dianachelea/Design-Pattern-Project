using DessignPatternProject.Observer;

namespace DessignPatternProject.Observer
{
    public class Manager : IManager
    {
        private string Action { get; set; }

        private List<IObserver> observers = new List<IObserver>();

        public Manager(string action) 
        {
            Action = action;
        }

        public string GetAction()
        {
            return Action;
        }   

        public void SetAction(string action)
        {
            Action = action;
            NotifyObservers();
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(Action);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            Console.WriteLine("Observer Added : " + observer.ToString());
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            Console.WriteLine("Observer Removed : " + observer.ToString());
            observers.Remove(observer);
        }
    }
}