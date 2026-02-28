namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== User: Anukun (Free Member) ===");
            IBookContent freeReader = new BookReaderProxy("Harry Potter and the Philosopher's Stone", false);

            freeReader.DisplayChapter(1);    
            freeReader.DisplayChapter(2);    
            freeReader.DownloadChapter(1);  

            Console.WriteLine("\n-----------------------------------\n");

            Console.WriteLine("=== User: Anukun (Premium Member) ===");
            IBookContent premiumReader = new BookReaderProxy("Harry Potter and the Philosopher's Stone", true);

            premiumReader.DisplayChapter(1);  
            premiumReader.DisplayChapter(2);  
            premiumReader.DownloadChapter(2);
        }
    }
}