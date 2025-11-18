namespace DessignPatternProject.Decorator
{
    public class PeacockEnclosure : IEnclosure
    {
        public string Animal { get; set; } = "Peacock";
        public string FenceType { get; set; } = "Wooden Fence";
        public string DoorType { get; set; } = "Sliding Door";
        public string GroundMaterial { get; set; } = "Grass";
        public string WaterFeature { get; set; } = "Small Pond";
        public string HeatingSystem { get; set; } = "Underfloor Heating";

        public IEnclosure BuildEnclosure()
        {
            return this; 
        }

        public override string ToString()
        {
            return $"Enclosure for {Animal} with: {FenceType}, {DoorType}, {GroundMaterial}, {WaterFeature}, {HeatingSystem}";
        }
    }
}