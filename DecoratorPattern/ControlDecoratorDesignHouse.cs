using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class ControlDecoratorDesignHouse
    {
        Control _target;
        public ControlDecoratorDesignHouse(Control target)
        {
            _target = target;
        }

        public ControlDecoratorDesignHouse DecorateWithHorizontalScrollBar()
        {
            _target = new HorizontalScrollBarDecorator(_target);
            return this;
        }
        public ControlDecoratorDesignHouse DecorateWithVerticalScrollBar()
        {
            _target = new VerticalScrollBarDecorator(_target);
            return this;
        }

        public Control GetDecoratorObject()
        {
            return _target;
        }
    }
}
