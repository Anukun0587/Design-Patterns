namespace Builder.Models
{
    public class Novel
    {
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Publisher { get; set; }
        public string? Content { get; set; }
        public string? Illustrations { get; set; }
        public string? Cover { get; set; }
        public string? Bookmark { get; set; }
        public string? Postcard { get; set; }

        public void DisplayInfo()
        {
            if (!string.IsNullOrEmpty(Title))
                Console.WriteLine($"Title: {Title}");

            if (!string.IsNullOrEmpty(Author))
                Console.WriteLine($"Author: {Author}");

            if (!string.IsNullOrEmpty(Publisher))
                Console.WriteLine($"Publisher: {Publisher}");

            if (!string.IsNullOrEmpty(Content))
                Console.WriteLine($"Content: {Content}");

            if (!string.IsNullOrEmpty(Illustrations))
                Console.WriteLine($"Illustrations: {Illustrations}");

            if (!string.IsNullOrEmpty(Cover))
                Console.WriteLine($"Cover: {Cover}");

            if (!string.IsNullOrEmpty(Bookmark))
                Console.WriteLine($"Bookmark: {Bookmark}");

            if (!string.IsNullOrEmpty(Postcard))
                Console.WriteLine($"Postcard: {Postcard}");
        }
    }
}