using Iterator.iterator;

namespace Iterator.collection
{
    public interface INovelCollection
    {
        INovelIterator createStatusIterator(string status);
        INovelIterator createCategoryIterator(string category);
        INovelIterator createPopularityIterator();
        public int getSize();
        public Novel getNovel(int index);
    }
}