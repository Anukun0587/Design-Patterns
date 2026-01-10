using Builder.Models;
namespace Builder.Builders
{
    public class TextbookBuilder : IBuilder
    {
        private Textbook textbook;

        public TextbookBuilder()
        {
            this.textbook = new Textbook();
        }

        public void Reset()
        {
            this.textbook = new Textbook();
        }

        public void BuildTitle()
        {
            this.textbook.Title = "Textbook Title";
        }

        public void BuildAuthor()
        {
            this.textbook.Author = "Textbook Author";
        }

        public void BuildPublisher()
        {
            this.textbook.Publisher = "Textbook Publisher";
        }

        public void BuildContent()
        {
            this.textbook.Content = "Textbook Content";
        }

        public void BuildIllustrations()
        {
            this.textbook.Illustrations = "Textbook Illustrations";
        }

        public void BuildCover()
        {
            this.textbook.Cover = "Textbook Cover";
        }

        public void BuildBookmark()
        {
            this.textbook.Bookmark = "Textbook Bookmark";
        }

        public void BuildPostcard()
        {
            this.textbook.Postcard = "Textbook Postcard";
        }

        public Textbook GetBook()
        {
            Textbook result = this.textbook;
            this.Reset();
            return result;
        }
    }
}