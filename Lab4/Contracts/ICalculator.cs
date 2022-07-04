namespace Lab4.Contracts
{
    internal abstract class ICalculator
    {
        protected object Parameter;

        public ICalculator(object parameter)
        {
            Parameter = parameter;
        }

        public abstract decimal Calculate();
    }
}
