namespace DessignPatternProject.Decorator
{
    public abstract class EnclosureDecorator : IEnclosure
    {
        protected IEnclosure enclosure;
        public string Animal
        {
            get
            {
                return enclosure.Animal;
            }
            set
            {
                enclosure.Animal = value;
            }
        }
        public EnclosureDecorator(IEnclosure enclosure)
        {
            this.enclosure = enclosure;
        }
        public virtual IEnclosure BuildEnclosure()
        {
            return enclosure.BuildEnclosure();
        }
    }
}