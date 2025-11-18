namespace DessignPatternProject.Decorator
{
    public interface IEnclosure
    {
        string Animal { get; set; }
        public string FenceType { get; set; }
        public string DoorType { get; set; }
        public string GroundMaterial { get; set; }
        public string WaterFeature { get; set; }
        public string HeatingSystem { get; set; }

        IEnclosure BuildEnclosure();
    }
}