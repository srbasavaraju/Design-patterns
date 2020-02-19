using AdapterPattern.Interfaces;
using System;

namespace AdapterPattern
{
    public class Adaptee: IAdaptee
    {
        public void SpecificRequest(string data)
        {
            Console.WriteLine("Adaptee : data received: {0}", data);
        }
    }
}
