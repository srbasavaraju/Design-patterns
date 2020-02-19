using StrategyPattern.Interfaces;
using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********Strategy pattern start ********************");
            CalculationStrategy addition = new CalculationStrategy(new Addition());
            Console.WriteLine("Addition: {0}", addition.calculate(10, 20));

            CalculationStrategy substraction = new CalculationStrategy(new Substraction());
            Console.WriteLine("Substraction: {0}", substraction.calculate(20, 10));

            CalculationStrategy multiplication = new CalculationStrategy(new Multiplication());
            Console.WriteLine("Multiplication: {0}", multiplication.calculate(10, 20));

            CalculationStrategy division = new CalculationStrategy(new Division());
            Console.WriteLine("Division: {0}", division.calculate(20, 10));

            Console.WriteLine("***********Strategy pattern end ********************");
        }
    }
}
