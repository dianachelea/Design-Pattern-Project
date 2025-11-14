namespace DessignPatternProject.Chain
{
    public class PeacockQuantityHandler : AnimalsQuantityHandler
    {
        public override void HandleRequest(int numberOfAnimals)
        {
            int canProvide = 5;

            int provided = Math.Min(numberOfAnimals, canProvide);
            Console.WriteLine($"PeacockQuantityHandler provided {provided} peacocks.");

            int remaining = numberOfAnimals - provided;
            if (remaining > 0)
            {
                NextHandler.HandleRequest(remaining);
            }
        }
    }
}