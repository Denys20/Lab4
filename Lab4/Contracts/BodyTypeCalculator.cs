using Lab4.Enums;

namespace Lab4.Contracts
{
    internal class BodyTypeCalculator : ICalculator
    {
        public BodyTypeCalculator(BodyType bodyType)
            : base(bodyType)
        {
        }

        public override decimal Calculate()
        {
            switch ((BodyType)Parameter)
            {
                case BodyType.Ectomorph:
                    return 1.1m;
                case BodyType.Mesomorph:
                    return 1.15m;
                case BodyType.Endomorph:
                    return 0.95m;
                default:
                    return 1;
            }
        }
    }
}
