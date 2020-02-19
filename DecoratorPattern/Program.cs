using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Control textBox = new TextBox();
            Control horizontalText = new HorizontalScrollBarDecorator(textBox);
            horizontalText.Paint();

            Control verticalText = new VerticalScrollBarDecorator(horizontalText);
            verticalText.Paint();

            Control control = new ControlDecoratorDesignHouse(new TextBox()).DecorateWithHorizontalScrollBar().DecorateWithVerticalScrollBar().GetDecoratorObject();
            control.Paint();
        }
    }
}
