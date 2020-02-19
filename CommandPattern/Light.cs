using System;

namespace CommandPattern
{
    public class Light: Interfaces.ILight
    {
        public void On()
        {
            Console.WriteLine("Light On ");
        }

        public void Off()
        {
            Console.WriteLine("Light Off ");
        }
    }
}
