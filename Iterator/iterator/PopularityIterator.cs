using Iterator.collection;

namespace Iterator.iterator
{
    public class PopularityIterator : INovelIterator
    {
        public List<Novel> novels;
        public int currentIndex;

        public PopularityIterator(INovelCollection novelCollection)
        {
            novels = new List<Novel>();
            currentIndex = 0;

            for (int i = 0; i < novelCollection.getSize(); i++)
            {
                novels.Add(novelCollection.getNovel(i));
            }

            novels = novels.OrderByDescending(n => n.GetViews()).ToList();
        }  

        public Novel getNext()
        {
            return novels[currentIndex++];
        }

        public bool hasMore()
        {
            return currentIndex < novels.Count;
        }
    }
}