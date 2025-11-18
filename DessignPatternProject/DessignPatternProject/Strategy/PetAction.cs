namespace DessignPatternProject.Strategy
{
    public class PetAction : ITakeCareActivities
    {
        public void TakeCare()
        {
            Console.WriteLine("Taking care of the pet.");
        }
    }
}