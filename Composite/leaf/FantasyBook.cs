namespace Composite.BookSystem
{
    public class FantasyBook : IBookItem
    {
        private int count;

        public FantasyBook(int count = 1)
        {
            this.count = count;
        }

        public void getDetails()
        {
            Console.WriteLine("Fantasy Book");
        }

        public int getCount()
        {
            return count;
        }
    }
}