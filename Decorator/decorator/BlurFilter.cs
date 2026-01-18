namespace DecoratorPattern.decorator
{
    public class BlurFilter : ImageFilterDecorator
    {
        public BlurFilter(IImage image) : base(image)
        {
        }

        public void addBlurFilter()
        {
            Console.WriteLine("Applying Blur Filter");
        }

        public override void render()
        {
            base.render();
            addBlurFilter();
        }
    }
}