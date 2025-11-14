namespace DessignPatternProject.Observer
{
    public class Observer : IObserver
    {
        public string UserName { get; set; }

        public Observer(string userName)
        {
            UserName = userName;
        }

        public void AddSubscription(IManager manager)
        {
            manager.RegisterObserver(this);
        }

        public void RemoveSubscription(IManager manager)
        {
            manager.RemoveObserver(this);
        }

        public void Update(string message)
        {
            Console.WriteLine("You can " + message + " the zoo.");
        }
    }
}