namespace DessignPatternProject.Chain
{
    public abstract class AnimalsQuantityHandler
    {
        public AnimalsQuantityHandler NextHandler;

        public void SetNextHandler(AnimalsQuantityHandler animalsQuantityHandler)
        {
            NextHandler = animalsQuantityHandler;
        }

        public abstract void HandleRequest(int numberOfAnimals);
    }
}