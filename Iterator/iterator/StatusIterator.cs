using Iterator.collection;

namespace Iterator.iterator
{
    public class StatusIterator : INovelIterator
    {
        public List<Novel> novels;
        public int index;
        public string targetStatus;

        public StatusIterator(INovelCollection novelCollection, string status)
        {
            novels = new List<Novel>();
            index = 0;
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
            return novels[index++];
        }

        public bool hasMore()
        {
            return index < novels.Count;
        }
    }
}