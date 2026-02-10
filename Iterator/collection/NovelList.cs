using Iterator.collection;

namespace Iterator.iterator
{
    public class NovelList : INovelCollection
    {
        private List<Novel> novels;

        public NovelList()
        {
            novels = new List<Novel>();
        }

        public void addNovel(Novel novel)
        {
            novels.Add(novel);
        }

        public Novel getNovel(int index)
        {
            return novels[index];
        }

        public int getSize()
        {
            return novels.Count;
        }

        public INovelIterator createStatusIterator(string status)
        {
            return new StatusIterator(this, status);
        }

        public INovelIterator createCategoryIterator(string category)
        {
            return new CategoryIterator(this, category);
        }

        public INovelIterator createPopularityIterator()
        {
            return new PopularityIterator(this);
        }
    }
}