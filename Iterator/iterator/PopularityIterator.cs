using Iterator.collection;

namespace Iterator.iterator
{
    public class PopularityIterator : INovelIterator
    {
        public List<Novel> novels;
        public int index;

        public PopularityIterator(INovelCollection novelCollection)
        {
            novels = new List<Novel>();
            index = 0;

            for (int i = 0; i < novelCollection.getSize(); i++)
            {
                novels.Add(novelCollection.getNovel(i));
            }

            novels = novels.OrderByDescending(n => n.GetViews()).ToList();
        }  

        public Novel getNext()
        {
            return novels[index++];
        }

        public bool hasMore()
        {
            return index < novels.Count;
        }
    }
}