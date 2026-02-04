namespace Composite.BookSystem
{
    public class ActionBook : IBookItem
    {
        private int count;

        public ActionBook(int count = 1)
        {
            this.count = count;
        }

        public void getDetails()
        {
            Console.WriteLine("Action Book");
        }

        public int getCount()
        {
            return count;
        }
    }
}