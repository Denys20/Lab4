using Lab4.Enums;

namespace Lab4.Contracts
{
    internal class SexCalculator : ICalculator
    {
        public SexCalculator(Sex sex)
            : base(sex)
        {
        }

        public override decimal Calculate()
        {
            switch ((Sex)Parameter)
            {
                case Sex.Female:
                    return -161;
                case Sex.Male:
                    return 5;
                default:
                    return 0;
            }
        }
    }
}
