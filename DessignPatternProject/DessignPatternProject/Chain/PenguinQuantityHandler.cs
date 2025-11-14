namespace DessignPatternProject.Chain
{
    public class PenguinQuantityHandler : AnimalsQuantityHandler
    {
        public override void HandleRequest(int numberOfAnimals)
        {
            Console.WriteLine($"PenguinQuantityHandler provided {numberOfAnimals} penguins.");
        }
    }
}