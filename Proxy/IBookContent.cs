namespace Proxy
{
    public interface IBookContent
    {
        public void DisplayChapter(int chapterNumber);
        public void DownloadChapter(int chapterNumber);
    }
}