namespace DessignPatternProject.Decorator
{
    public class PenguinEnclosure : EnclosureDecorator
    {
        public PenguinEnclosure(IEnclosure enclosure) : base(enclosure) 
        {
            Animal = "Penguin";
        }

        public override IEnclosure BuildEnclosure()
        {
            enclosure.BuildEnclosure();
            FenceType = "Glass Fence";
            WaterFeature = "Large Pool with Slide";
            GroundMaterial = "Ice and Snow";
            HeatingSystem = "Cooling System";
            Console.WriteLine($"Upgrading enclosure for {Animal} with: {FenceType} {DoorType} {GroundMaterial} {WaterFeature} {HeatingSystem}");
            return enclosure;
        }
    }
}