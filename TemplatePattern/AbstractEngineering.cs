using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public abstract class AbstractEngineering
    {
        public void OnGraduation()
        {
            BunkClasses();
            CafeteriaHangout();
            PassingPercentage();
        }

        private void BunkClasses()
        {
            Console.WriteLine("Class bunked.....");
        }

        private void CafeteriaHangout()
        {
            Console.WriteLine("Cafeteria hang out");
        }

        public abstract void PassingPercentage();
    }
}
