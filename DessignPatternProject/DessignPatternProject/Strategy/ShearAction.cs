namespace DessignPatternProject.Strategy
{
    public class ShearAction : ITakeCareActivities
    {
        public void TakeCare()
        {
            Console.WriteLine("Shearing the animal.");
        }
    }
}