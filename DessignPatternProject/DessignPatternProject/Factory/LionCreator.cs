using DessignPatternProject.Models;

namespace DessignPatternProject.Factory
{
    public class LionCreator : AnimalCreator
    {
        public override Animal BuyAnimal(string name)
        {
            Animal lion = new Lion(name);
            return lion;
        }
    }
}