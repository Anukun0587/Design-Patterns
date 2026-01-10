using Builder.Models;
namespace Builder.Builders
{
    public class NovelBuilder : IBuilder
    {
        private Novel novel;

        public NovelBuilder()
        {
            this.novel = new Novel();
        }

        public void Reset()
        {
            this.novel = new Novel();
        }

        public void BuildTitle()
        {
            this.novel.Title = "Novel Title";
        }

        public void BuildAuthor()
        {
            this.novel.Author = "Novel Author";
        }

        public void BuildPublisher()
        {
            this.novel.Publisher = "Novel Publisher";
        }

        public void BuildContent()
        {
            this.novel.Content = "Novel Content";
        }

        public void BuildIllustrations()
        {
            this.novel.Illustrations = "Novel Illustrations";
        }

        public void BuildCover()
        {
            this.novel.Cover = "Novel Cover";
        }

        public void BuildBookmark()
        {
            this.novel.Bookmark = "Novel Bookmark";
        }

        public void BuildPostcard()
        {
            this.novel.Postcard = "Novel Postcard";
        }

        public Novel GetBook()
        {
            Novel result = this.novel;
            this.Reset();
            return result;
        }
    }
}