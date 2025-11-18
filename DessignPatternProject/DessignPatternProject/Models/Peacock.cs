namespace DessignPatternProject.Models
{
    public class Peacock : Animal
    {
        public override string Species
        {
            get
            {
                return "Peacock";
            }
        }

        public Peacock(string name) : base(name) { }
    }
}