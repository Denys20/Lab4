namespace Lab4.Contracts
{
    internal class HeightCalculator : ICalculator
    {
        public HeightCalculator(decimal height)
            : base(height)
        {
        }

        public override decimal Calculate()
        {
            return (decimal)Parameter * 6.25m;
        }
    }
}
