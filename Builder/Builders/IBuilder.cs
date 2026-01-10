namespace Builder.Builders
{
    public interface IBuilder
    {
        void Reset();
        void BuildTitle();
        void BuildAuthor();
        void BuildPublisher();
        void BuildContent();
        void BuildIllustrations();
        void BuildCover();
        void BuildBookmark();
        void BuildPostcard();
    }
}