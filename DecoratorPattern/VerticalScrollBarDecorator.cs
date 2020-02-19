using System;

namespace DecoratorPattern
{
    public class VerticalScrollBarDecorator : ControlDecorator
    {
        public VerticalScrollBarDecorator(Control control) : base(control) { }


        public override void Paint()
        {
            Console.WriteLine("Vertical scroll enabled");
        }
    }
}
