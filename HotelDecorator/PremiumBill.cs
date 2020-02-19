using System;

namespace HotelDecorator
{
    public class PremiumBill: BillDecorator
    {
        public PremiumBill(Control control) : base(control) { }

        public void GetTotalPrice()
        {
            Console.WriteLine("Premium bill decorator");
        }
    }
}
