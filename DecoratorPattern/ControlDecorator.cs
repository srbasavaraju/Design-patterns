namespace DecoratorPattern
{
    public abstract class ControlDecorator : Control
    {
        private readonly Control _target;

        protected ControlDecorator(Control target)
        {
            _target = target;
        }

        public override void Paint()
        {
            _target.Paint();
        }
    }
}
