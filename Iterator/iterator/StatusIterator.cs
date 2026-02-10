using Iterator.collection;

namespace Iterator.iterator
{
    public class StatusIterator : INovelIterator
    {
        public List<Novel> novels;
        public int currentIndex;
        public string targetStatus;

        public StatusIterator(INovelCollection novelCollection, string status)
        {
            novels = new List<Novel>();
            currentIndex = 0;
            targetStatus = status;

            for (int i = 0; i < novelCollection.getSize(); i++)
            {
                Novel novel = novelCollection.getNovel(i);
                if (novel.GetStatus() == status)
                {
                    novels.Add(novel);
                }
            }
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