using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public class FirstYearEngineering : AbstractEngineering
    {
        public override void PassingPercentage()
        {
            Console.WriteLine("First rank");
        }
    }
}
