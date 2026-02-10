using Iterator.collection;

namespace Iterator.iterator
{
    public interface INovelIterator
    {
        public Novel getNext();
        public bool hasMore();

    }
}