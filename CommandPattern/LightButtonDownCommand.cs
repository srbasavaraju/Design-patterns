using CommandPattern.Interfaces;

namespace CommandPattern
{
    public class LightButtonDownCommand : ICommand
    {
        readonly ILight _light;
        public LightButtonDownCommand(ILight light)
        {
            _light = light;
        }
        public void execute()
        {
            _light.Off();
        }
    }
}
