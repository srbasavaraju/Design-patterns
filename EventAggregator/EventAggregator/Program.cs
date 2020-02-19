using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace testsolution
{
    class Program
    {
        static void Main(string[] args)
        {
            EventAggregator eve = new EventAggregator();
            Publisher pub = new Publisher(eve);
            Subscriber sub = new Subscriber(eve);

            pub.PublishMessage();

            Console.ReadLine();
        }
    }
}
