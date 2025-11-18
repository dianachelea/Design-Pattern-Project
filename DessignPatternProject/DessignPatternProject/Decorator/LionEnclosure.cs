namespace DessignPatternProject.Decorator
{
    public class LionEnclosure : EnclosureDecorator
    {
        public LionEnclosure(IEnclosure enclosure) : base(enclosure) 
        { 
            Animal = "Lion";
        }

        public override IEnclosure BuildEnclosure()
        {
            enclosure.BuildEnclosure();
            FenceType = "High and Strong Fence";
            DoorType = "Reinforced Door";
            GroundMaterial = "Grass and Sand Mix";
            WaterFeature = "Large Water Pool";
            HeatingSystem = "Advanced Heating System";
            Console.WriteLine($"Upgrading enclosure for {Animal} with: {FenceType} {DoorType} {GroundMaterial} {WaterFeature} {HeatingSystem}");
            return enclosure;
        }
    }
}