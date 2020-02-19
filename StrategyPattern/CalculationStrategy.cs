using StrategyPattern.Interfaces;

namespace StrategyPattern
{
    public class CalculationStrategy
    {
        private readonly ICalculateOperation _calculateOperation;
        public CalculationStrategy(ICalculateOperation calculateOperation)
        {
            _calculateOperation = calculateOperation;
        }

        public int calculate(int val1, int val2)
        {
            return _calculateOperation.calculation(val1, val2);
        }
    }
}
