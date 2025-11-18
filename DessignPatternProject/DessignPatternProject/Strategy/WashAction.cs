namespace DessignPatternProject.Strategy
{
    public class WashAction : ITakeCareActivities
    {
        public void TakeCare()
        {
            Console.WriteLine("Washing the animal.");
        }
    }
}