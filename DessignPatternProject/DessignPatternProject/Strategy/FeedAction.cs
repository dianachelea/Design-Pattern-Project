namespace DessignPatternProject.Strategy
{
    public class FeedAction : ITakeCareActivities
    {
        public void TakeCare()
        {
            Console.WriteLine("Feeding the animal.");
        }
    }
}