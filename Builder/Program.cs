using Builder.Models;
using Builder.Builders;
using Builder.Director;

namespace Builder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Creating Director
            BookDirector director = new BookDirector();

            // Building a Novel
            Console.WriteLine("Building a Standard Novel:");
            NovelBuilder novelBuilder = new NovelBuilder();
            director.MakeStandardBook(novelBuilder);
            Novel novel = novelBuilder.GetBook();
            novel.DisplayInfo();

            Console.WriteLine("\n" + new string('-', 50) + "\n");

            // Building a Special Edition Novel
            Console.WriteLine("Building a Special Edition Novel:");
            director.MakeSpecialEditionBook(novelBuilder);
            Novel specialNovel = novelBuilder.GetBook();
            specialNovel.DisplayInfo();

            Console.WriteLine("\n" + new string('-', 50) + "\n");

            // Building a Textbook
            Console.WriteLine("Building a Standard Textbook:");
            TextbookBuilder textbookBuilder = new TextbookBuilder();
            director.MakeStandardBook(textbookBuilder);
            Textbook textbook = textbookBuilder.GetBook();
            textbook.DisplayInfo();

            Console.WriteLine("\n" + new string('-', 50) + "\n");

            // Building without Director
            Console.WriteLine("Building a Novel without Director:");
            NovelBuilder customBuilder = new NovelBuilder();
            customBuilder.Reset();
            customBuilder.BuildTitle();
            customBuilder.BuildAuthor();
            customBuilder.BuildIllustrations();
            customBuilder.BuildCover();
            customBuilder.BuildBookmark();
            Novel customNovel = customBuilder.GetBook();
            customNovel.DisplayInfo();

            Console.WriteLine("\n" + new string('-', 50) + "\n");

            Console.WriteLine("Building a Textbook without Director:");
            TextbookBuilder customBuilder2 = new TextbookBuilder();
            customBuilder2.Reset();
            customBuilder2.BuildTitle();
            customBuilder2.BuildCover();
            Textbook textbook1 = customBuilder2.GetBook();
            textbook1.DisplayInfo();
        }
    }
}