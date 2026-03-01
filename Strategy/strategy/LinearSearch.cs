namespace Strategy.strategy
{
    public class LinearSearch : IStrategy
    {
        public int search(int[] data, int target)
        {
            Console.WriteLine("[Linear Search] Searching for " + target);
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}