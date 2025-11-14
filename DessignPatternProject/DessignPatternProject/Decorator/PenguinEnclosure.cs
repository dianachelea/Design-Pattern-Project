using DessignPatternProject.Models;

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
            AddFeature(enclosure);
            return enclosure;
        }

        public void AddFeature(IEnclosure enclosure)
        {
            if( enclosure is PeacockEnclosure basic)
            {
                basic.FenceType = "Glass Fence"; 
                basic.WaterFeature = "Large Pool with Slide";
                basic.GroundMaterial = "Ice and Snow";
                basic.HeatingSystem = "Cooling System";
                Console.WriteLine($"Upgrading enclosure for {Animal} with: {basic.FenceType} {basic.DoorType} {basic.GroundMaterial} {basic.WaterFeature} {basic.HeatingSystem}");
            }
        }
    }
}