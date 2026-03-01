namespace Strategy.strategy
{
    public class BinarySearch : IStrategy
    {
        public int search(int[] data, int target)
        {
            Console.WriteLine("[Binary Search] Searching for " + target);
            int left = 0;
            int right = data.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (data[mid] == target)
                {
                    return mid;
                }
                else if (data[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }
    }
}