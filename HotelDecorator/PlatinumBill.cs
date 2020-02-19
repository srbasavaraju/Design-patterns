using System;

namespace HotelDecorator
{
    public class PlatinumBill: BillDecorator
    {
        public PlatinumBill(Control control) : base(control) { }

        public void GetTotalPrice()
        {
            Console.WriteLine("PlatinumBill bill decorator");
        }
    }
}
