namespace Lab4.Contracts
{
    internal class WeightCalculator : ICalculator
    {
        public WeightCalculator(decimal weight)
            : base(weight)
        {
        }

        public override decimal Calculate()
        {
            return (decimal)Parameter * 10;
        }
    }
}
