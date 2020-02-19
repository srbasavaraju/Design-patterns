using System;

namespace DecoratorPattern
{
    public class HorizontalScrollBarDecorator: ControlDecorator
    {
        public HorizontalScrollBarDecorator(Control control) : base(control) { }
        

        public override void Paint()
        {
            Console.WriteLine("Horizontal scroll enabled");
        }
    }
}
