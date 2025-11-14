namespace DessignPatternProject.Strategy
{
    public class CareTaker
    {
        private ITakeCareActivities _takeCareActivities;

        public CareTaker(ITakeCareActivities takeCareActivites)
        {
            _takeCareActivities = takeCareActivites;
        }

        public void SetTakeCareActivities(ITakeCareActivities takeCareActivities)
        {
            _takeCareActivities = takeCareActivities;
        }

        public void TakeCare()
        {
            _takeCareActivities.TakeCare();
        }
    }
}