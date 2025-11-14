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
            AddFeatures(enclosure);
            return enclosure;
        }
        
        public void AddFeatures(IEnclosure enclosure)
        {
            if(enclosure is PeacockEnclosure basic)
            {
                basic.FenceType = "High and Strong Fence";
                basic.DoorType = "Reinforced Door";
                basic.GroundMaterial = "Grass and Sand Mix";
                basic.WaterFeature = "Large Water Pool";
                basic.HeatingSystem = "Advanced Heating System";
                Console.WriteLine($"Upgrading enclosure for {Animal} with: {basic.FenceType} {basic.DoorType} {basic.GroundMaterial} {basic.WaterFeature} {basic.HeatingSystem}");
            }
        }

    }
}