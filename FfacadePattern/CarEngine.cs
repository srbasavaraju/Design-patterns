using System;

namespace FacadePattern
{
    public class CarEngine : AbstractAssemble
    {
        public override void assemble()
        {
            Console.WriteLine("Assembling the car engine");
        }
    }
}
