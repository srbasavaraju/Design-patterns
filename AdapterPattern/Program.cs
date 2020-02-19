using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************Adapter pattern start***************");
            Target target = new Adapter();
            target.request("data");
            Console.WriteLine("****************Adapter pattern end***************");
        }
    }
}
