namespace DessignPatternProject.Decorator
{
    public abstract class EnclosureDecorator : IEnclosure
    {
        protected IEnclosure enclosure;
        public string Animal { get => enclosure.Animal; set => enclosure.Animal = value; } 
        public string FenceType { get => enclosure.FenceType; set => enclosure.FenceType = value; }
        public string DoorType { get => enclosure.DoorType; set => enclosure.DoorType = value; }
        public string GroundMaterial { get => enclosure.GroundMaterial; set => enclosure.GroundMaterial = value; }
        public string WaterFeature { get => enclosure.WaterFeature; set => enclosure.WaterFeature = value; }
        public string HeatingSystem { get => enclosure.HeatingSystem; set => enclosure.HeatingSystem = value; }
        public EnclosureDecorator(IEnclosure enclosure)
        {
            this.enclosure = enclosure;
        }
        public virtual IEnclosure BuildEnclosure()
        {
            return enclosure.BuildEnclosure();
        }
        public override string ToString() => enclosure.ToString();
    }
}