using System;
using DecoratorPattern;
using DecoratorPattern.decorator;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Base Image ---");
            IImage baseImage = new BaseImage("sample_image.jpg");
            baseImage.render();

            Console.WriteLine("\n--- Applying Grayscale Filter ---");
            IImage addGrayscaleImage = new GrayscaleFilter(baseImage);
            addGrayscaleImage.render();

            Console.WriteLine("\n--- Applying Brightness Filter And Grayscale Filter---");
            IImage addGrayscaleImage_and_Brightness = new BrightnessFilter(addGrayscaleImage);
            addGrayscaleImage_and_Brightness.render();

            Console.WriteLine("\n--- Applying Blur Filter And Grayscale Filter And Brightness Filter---");
            IImage addGrayscaleImage_and_Brightness_and_Blur = new BlurFilter(addGrayscaleImage_and_Brightness);
            addGrayscaleImage_and_Brightness_and_Blur.render();
        }
    }
}