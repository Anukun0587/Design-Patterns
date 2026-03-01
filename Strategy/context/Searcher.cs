using Strategy.strategy;

namespace Strategy.context
{
    public class Searcher
    {
        private IStrategy strategy = null!;
        private int[] data = null!;

        public void setData(int[] data)
        {
            this.data = data;
        }

        public void setStrategy(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void search(int target)
        {
            int index = strategy.search(data, target);

            if (index != -1)
            {
                Console.WriteLine($"  พบ {target} ที่ index [{index}]\n");
            }
            else
            {
                Console.WriteLine($"  ไม่พบ {target} ในข้อมูล\n");
            }
        }
    }
}