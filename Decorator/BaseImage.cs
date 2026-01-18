namespace DecoratorPattern
{
    public class BaseImage : IImage
    {
        private string fileName;

        public BaseImage(string fileName)
        {
            this.fileName = fileName;
        }

        public void render()
        {
            Console.WriteLine("Base Image");
            Console.WriteLine("Rendering image: " + fileName);
        }
    }
}