namespace DecoratorPattern.decorator
{
    public class BrightnessFilter : ImageFilterDecorator
    {
        public BrightnessFilter(IImage image) : base(image)
        {
        }

        public void addBrightnessFilter()
        {
            Console.WriteLine("Applying Brightness Filter");
        }

        public override void render()
        {
            base.render();
            addBrightnessFilter();
        }
    }
}