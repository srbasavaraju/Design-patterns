using System;
using System.Collections.Generic;
using System.Text;

namespace HotelDecorator
{
    public abstract class BillDecorator: Control
    {
        Control _control;
        public BillDecorator(Control control)
        {
            _control = control;

        }

        public override void GetTotalPrice()
        {
            _control.GetTotalPrice();
        }
    }
}
