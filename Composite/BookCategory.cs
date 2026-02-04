namespace Composite
{
    public class BookCategory : IBookItem
    {
        private string categoryName;
        private List<IBookItem> items;

        public BookCategory(string categoryName)
        {
            this.categoryName = categoryName;
            this.items = new List<IBookItem>();
        }

        public void add(IBookItem item)
        {
            items.Add(item);
        }

        public void getDetails()
        {
            Console.WriteLine($"{categoryName} []");
            foreach (var item in items)
            {
                item.getDetails();
            }
        }

        public int getCount()
        {
            int total = 0;
            foreach (var item in items)
            {
                total += item.getCount();
            }
            return total;
        }
    }
}