using System;
namespace FacadePattern
{
    public class CarAccessories : AbstractAssemble
    {
        public override void assemble()
        {
            Console.WriteLine("Assembling the car asseccories");
        }
    }
}
