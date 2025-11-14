namespace DessignPatternProject.Decorator
{
    public interface IEnclosure
    {
        string Animal { get; set; }
        IEnclosure BuildEnclosure();
    }
}