using Iterator.collection;

namespace Iterator.iterator
{
    public class CategoryIterator : INovelIterator
    {
        public List<Novel> novels;
        public int currentIndex;
        public string targetCategory;

        public CategoryIterator(INovelCollection novelCollection, string category)
        {
            novels = new List<Novel>();
            currentIndex = 0;
            targetCategory = category;

            for (int i = 0; i < novelCollection.getSize(); i++)
            {
                Novel novel = novelCollection.getNovel(i);
                if (novel.GetCategory() == targetCategory)
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