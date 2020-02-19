using System;

namespace TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************Template pattern start *******************");
            Console.WriteLine("First year engineering");
            AbstractEngineering firstYearEngineering = new FirstYearEngineering();
            firstYearEngineering.OnGraduation();

            Console.WriteLine("Second year engineering");
            AbstractEngineering secondYearEngineering = new SecondYearEngineering();
            secondYearEngineering.OnGraduation();

            Console.WriteLine("Third year engineering");
            AbstractEngineering thirdyearEngineering = new ThirdYearEngineering();
            thirdyearEngineering.OnGraduation();

            Console.WriteLine("Fourth year engineering");
            AbstractEngineering fourtYearEngineering = new FourthYearEngineering();
            fourtYearEngineering.OnGraduation();

            Console.WriteLine("*************Template pattern end *******************");
        }
    }
}
