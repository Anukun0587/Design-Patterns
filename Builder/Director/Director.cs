using Builder.Builders;
namespace Builder.Director
{
    public class BookDirector
    {
        public void MakeStandardBook(IBuilder builder)
        {
            builder.Reset();
            builder.BuildTitle();
            builder.BuildAuthor();
            builder.BuildPublisher();
            builder.BuildContent();
            builder.BuildIllustrations();
            builder.BuildCover();
        }

        public void MakeSpecialEditionBook(IBuilder builder)
        {
            builder.Reset();
            builder.BuildTitle();
            builder.BuildAuthor();
            builder.BuildPublisher();
            builder.BuildContent();
            builder.BuildIllustrations();
            builder.BuildCover();
            builder.BuildBookmark();
            builder.BuildPostcard();
        }
    }
}