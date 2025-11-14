using DessignPatternProject.Models;

namespace DessignPatternProject.Factory
{
    public abstract class AnimalCreator
    {
        public abstract Animal BuyAnimal(string name);
        public Animal Create(string name)
        {
            return this.BuyAnimal(name);
        }
    }
}