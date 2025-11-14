using DessignPatternProject.Chain;
using DessignPatternProject.Decorator;
using DessignPatternProject.Factory;
using DessignPatternProject.Models;
using DessignPatternProject.Observer;
using DessignPatternProject.Strategy;

class Program
{
    static void Main(string[] args)
    { 
        Console.WriteLine("Strategy Pattern:");
        RunStrategyPattern();
        Console.WriteLine("Chain of Responsibility Pattern:");
        RunChainPattern();
        Console.WriteLine("Factory Pattern:");
        RunFactoryPattern();
        Console.WriteLine("Decorator Pattern:");
        RunDecoratorPattern();
        Console.WriteLine("Observer Pattern:");
        RunObserverPattern();
    }

    private static void RunStrategyPattern()
    {
        Console.WriteLine("Penguin care:");
        var caretaker = new CareTaker(new WashAction());
        caretaker.TakeCare();
        caretaker.SetTakeCareActivities(new FeedAction());
        caretaker.TakeCare();
        caretaker.SetTakeCareActivities(new PetAction());
        caretaker.TakeCare();

        Console.WriteLine("Lion care:");
        caretaker.SetTakeCareActivities(new FeedAction());
        caretaker.TakeCare();
        caretaker.SetTakeCareActivities(new WashAction());
        caretaker.TakeCare();
        caretaker.SetTakeCareActivities(new ShearAction());
        caretaker.TakeCare();

        Console.WriteLine("Peacock care:");
        caretaker.SetTakeCareActivities(new FeedAction());
        caretaker.TakeCare();
    }

    private static void RunFactoryPattern()
    {
        AnimalCreator lionCreator = new LionCreator();
        AnimalCreator penguinCreator = new PenguinCreator();
        AnimalCreator peacockCreator = new PeacockCreator();

        Animal lion = lionCreator.Create("Simba");
        Animal penguin = penguinCreator.Create("Pingu");
        Animal peacock = peacockCreator.Create("Pecky");

        Console.WriteLine(lion);
        Console.WriteLine(penguin);
        Console.WriteLine(peacock);
    }

    private static void RunDecoratorPattern()
    {
        IEnclosure baseForPeacock = new PeacockEnclosure();
        baseForPeacock.BuildEnclosure();
        Console.WriteLine(baseForPeacock.ToString());

        var penguinDecorator = new PenguinEnclosure(baseForPeacock);
        penguinDecorator.BuildEnclosure();
        Console.WriteLine(penguinDecorator.ToString());

        var lionDecorator = new LionEnclosure(baseForPeacock);
        lionDecorator.BuildEnclosure();
        Console.WriteLine(lionDecorator.ToString());
    }

    private static void RunChainPattern()
    {
        var zooChain = new ZooQuantityAnimals();

        zooChain.RequestAnimals(20);
        
        zooChain.RequestAnimals(50);

        zooChain.RequestAnimals(0);
    }

    private static void RunObserverPattern()
    {
        var manager = new Manager("open");
        var observer1 = new Observer("Ana");
        var observer2 = new Observer("Bianca");

        observer1.AddSubscription(manager);
        observer2.AddSubscription(manager);
        manager.NotifyObservers();

        manager.SetAction("closed");

        observer1.RemoveSubscription(manager);

        manager.SetAction("open");
    }
}