namespace DessignPatternProject.Models
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public abstract string Species { get; }
        
        protected Animal(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"{Species} {Name}";
        }
    }
}