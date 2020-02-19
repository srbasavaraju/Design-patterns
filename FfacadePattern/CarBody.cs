using System;
namespace FacadePattern
{
    public class CarBody : AbstractAssemble
    {
        public override void assemble()
        {
            Console.WriteLine("Assembling the car body");
        }
    }
}
