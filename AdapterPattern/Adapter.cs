using AdapterPattern.Interfaces;
using System;

namespace AdapterPattern
{
    public class Adapter : Target
    {
        readonly IAdaptee adaptee = new Adaptee();
        public override void request(string data)
        {
            Console.WriteLine("adapter request");
            adaptee.SpecificRequest(data);
        }
    }
}
