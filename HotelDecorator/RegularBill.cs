using System;
using System.Collections.Generic;
using System.Text;

namespace HotelDecorator
{
    public class RegularBill : BillDecorator
    {
        public RegularBill(Control control) : base(control) { }
        
        public void GetTotalPrice()
        {
            Console.WriteLine("Regular bill decorator");
        }
    }
}
