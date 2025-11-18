using DessignPatternProject.Models;

namespace DessignPatternProject.Factory
{
    public class PeacockCreator : AnimalCreator
    {
        public override Animal BuyAnimal(string name)
        {
            Animal peacock = new Peacock(name);
            return peacock;
        }
    }
}