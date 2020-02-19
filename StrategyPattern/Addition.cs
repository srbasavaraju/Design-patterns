using StrategyPattern.Interfaces;

namespace StrategyPattern
{
    public class Addition : ICalculateOperation
    {
        public int calculation(int value1, int value2)
        {
            return value1 + value2;
        }
    }
}
