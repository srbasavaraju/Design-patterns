using CommandPattern.Interfaces;

namespace CommandPattern
{
    public class LightButtonUpCommand : ICommand
    {
        readonly ILight _light;
        public LightButtonUpCommand(ILight light)
        {
            _light = light;
        }
        public void execute()
        {
            _light.On();
        }
    }
}
