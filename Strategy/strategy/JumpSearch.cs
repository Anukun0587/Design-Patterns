namespace Strategy.strategy
{
    public class JumpSearch : IStrategy
    {
        public int search(int[] data, int target)
        {
            Console.WriteLine("[Jump Search] Searching for " + target);
            int n = data.Length;
            int step = (int)Math.Sqrt(n);
            int prev = 0;

            while (data[Math.Min(step, n) - 1] < target)
            {
                prev = step;
                step += (int)Math.Sqrt(n);
                if (prev >= n) return -1;
            }

            while (data[prev] < target)
            {
                prev++;
                if (prev == Math.Min(step, n)) return -1;
            }

            return data[prev] == target ? prev : -1;
        }
    }
}