namespace DessignPatternProject.Chain
{
    public class ZooQuantityAnimals
    {
        private PeacockQuantityHandler peacockQuantityHandler = new PeacockQuantityHandler();
        private LionQuantityHandler lionQuantityHandler = new LionQuantityHandler();
        private PenguinQuantityHandler penguinQuantityHandler = new PenguinQuantityHandler();

        public ZooQuantityAnimals()
        {
            peacockQuantityHandler.SetNextHandler(lionQuantityHandler);
            lionQuantityHandler.SetNextHandler(penguinQuantityHandler);
        }

        public void RequestAnimals(int numberOfAnimals)
        {
            if(numberOfAnimals <= 0)
            { 
                Console.WriteLine("Number of animals cannot be negative or zero.");
                return;
            }
            peacockQuantityHandler.HandleRequest(numberOfAnimals);
        }
    }
}