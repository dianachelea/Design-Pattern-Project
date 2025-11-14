namespace DessignPatternProject.Decorator
{
    public class PeacockEnclosure : IEnclosure
    {
        public string Animal { get; set; } = "Peacock";
        public string FenceType { get; set; }
        public string DoorType { get; set; }
        public string GroundMaterial { get; set; }
        public string WaterFeature { get; set; }
        public string HeatingSystem { get; set; }

        public IEnclosure BuildEnclosure()
        {
            FenceType = "Wooden Fence";
            DoorType = "Sliding Door";
            GroundMaterial = "Grass";
            WaterFeature = "Small Pond";
            HeatingSystem = "Underfloor Heating";
            Console.WriteLine($"Building enclosure for {Animal} with: {FenceType} {DoorType} {GroundMaterial} {WaterFeature} {HeatingSystem}");
            return this;
        }

        public override string ToString()
        {
            return $"Enclosure for {Animal} with: {FenceType}, {DoorType}, {GroundMaterial}, {WaterFeature}, {HeatingSystem}";
        }
    }
}