namespace Lab4.Contracts
{
    internal class AgeCalculator : ICalculator
    {
        public AgeCalculator(int age)
            : base(age)
        {
        }

        public override decimal Calculate()
        {
            return (int)Parameter * -5;
        }
    }
}
