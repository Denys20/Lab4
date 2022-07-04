using Lab4.Contracts;

namespace Lab4
{
    internal class CaloriesCalculatorFacade
    {
        private AgeCalculator ageCalculator;
        private HeightCalculator heightCalculator;
        private BodyTypeCalculator bodyTypeCalculator;
        private PhysicalActivityCalculator physicalActivityCalculator;
        private SexCalculator sexCalculator;
        private WeightCalculator weightCalculator;

        public CaloriesCalculatorFacade(AgeCalculator ageCalculator, HeightCalculator heightCalculator,
            BodyTypeCalculator bodyTypeCalculator, PhysicalActivityCalculator physicalActivityCalculator,
            SexCalculator sexCalculator, WeightCalculator weightCalculator)
        {
            this.ageCalculator = ageCalculator;
            this.heightCalculator = heightCalculator;
            this.bodyTypeCalculator = bodyTypeCalculator;
            this.physicalActivityCalculator = physicalActivityCalculator;
            this.sexCalculator = sexCalculator;
            this.weightCalculator = weightCalculator;
        }

        public decimal Calculate()
        {
            return (ageCalculator.Calculate() + heightCalculator.Calculate() +
                weightCalculator.Calculate() + sexCalculator.Calculate()) *
                physicalActivityCalculator.Calculate() * bodyTypeCalculator.Calculate();
        }
    }
}
