using DessignPatternProject.Models;

namespace DessignPatternProject.Factory
{
    public class PenguinCreator : AnimalCreator
    {
        public override Animal BuyAnimal(string name)
        {
            Animal penguin = new Penguin(name);
            return penguin;
        }
    }
}