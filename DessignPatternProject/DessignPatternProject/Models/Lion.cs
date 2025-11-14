namespace DessignPatternProject.Models
{
    public class Lion : Animal
    {
        public override string Species
        {
            get
            {
                return "Lion";
            }
        }

        public Lion(string name) : base(name) { }
    }
}
