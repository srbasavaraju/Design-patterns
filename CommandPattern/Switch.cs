using CommandPattern.Interfaces;
using System.Collections.Generic;

namespace CommandPattern
{
    public class Switch
    {
        public void Execute(ICommand command)
        {
            command.execute();
        }
    }
}
