namespace DecoratorPattern.decorator
{
    public class ImageFilterDecorator : IImage
    {
        public IImage image;


        public ImageFilterDecorator(IImage image)
        {
            this.image = image;
        }

        public virtual void render()
        {
            image.render();
        }
    }
}