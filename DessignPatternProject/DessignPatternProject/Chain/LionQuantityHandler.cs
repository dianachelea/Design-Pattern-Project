namespace DessignPatternProject.Chain
{
    public class LionQuantityHandler : AnimalsQuantityHandler
    {
        public override void HandleRequest(int numberOfAnimals)
        {
            int canProvide = 10;

            int provided = Math.Min(numberOfAnimals, canProvide);
            Console.WriteLine($"LionQuantityHandler provided {provided} lions.");

            int remaining = numberOfAnimals - provided;
            if (remaining >0)
            {
                NextHandler.HandleRequest(remaining);
            }
        }
    }
}