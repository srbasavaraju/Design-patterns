using CommandPattern.Interfaces;
using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********Command pattern start **************");

            Console.WriteLine("Enter Commands (ON/OFF) : ");
            string cmd = Console.ReadLine();

            ILight tubelight = new Light();

            ICommand lightButtonUp = new LightButtonUpCommand(tubelight);
            ICommand lightButtonDown = new LightButtonDownCommand(tubelight);

            Switch s = new Switch();

            if (cmd == "ON")
            {
                s.Execute(lightButtonUp);
            }
            else
            {
                s.Execute(lightButtonDown);
            }

            Console.WriteLine("***********Command pattern end **************");
            Console.ReadKey();
        }
    }
}
