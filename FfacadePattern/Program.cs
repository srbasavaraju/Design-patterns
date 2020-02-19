using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************Facade Pattern start**********************");
            ICarFacade carFacade = new CarFacade();
            carFacade.AssembleCar();
            Console.WriteLine("*********************Facade Pattern end**********************");
            Console.ReadLine();
        }
    }
}
