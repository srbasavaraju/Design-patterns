using System;

namespace DecoratorPattern
{
    public class TextBox : Control
    {
        public override void Paint()
        {
            Console.WriteLine("TextBox: Paint method");
        }
    }
}
