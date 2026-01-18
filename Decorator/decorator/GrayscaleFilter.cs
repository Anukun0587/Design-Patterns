namespace DecoratorPattern.decorator
{
    public class GrayscaleFilter : ImageFilterDecorator
    {
        public GrayscaleFilter(IImage image) : base(image)
        {
        }

        public void addGrayscaleFilter()
        {
            Console.WriteLine("Applying Grayscale Filter");
        }

        public override void render()
        {
            base.render();
            addGrayscaleFilter();
        }
    }
}