namespace Composite.BookSystem
{
    public class RomanceBook : IBookItem
    {
        private int count;

        public RomanceBook(int count = 1)
        {
            this.count = count;
        }

        public void getDetails()
        {
            Console.WriteLine("Romance Book");
        }

        public int getCount()
        {
            return count;
        }
    }
}