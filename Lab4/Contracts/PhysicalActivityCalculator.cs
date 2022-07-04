using Lab4.Enums;

namespace Lab4.Contracts
{
    internal class PhysicalActivityCalculator : ICalculator
    {
        public PhysicalActivityCalculator(ActivityType activityType)
            : base(activityType)
        {
        }

        public override decimal Calculate()
        {
            switch ((ActivityType)Parameter)
            {
                case ActivityType.Low:
                    return 1.2m;
                case ActivityType.Medium:
                    return 1.55m;
                case ActivityType.High:
                    return 1.9m;
                default:
                    return 1.375m;
            }
        }
    }
}
