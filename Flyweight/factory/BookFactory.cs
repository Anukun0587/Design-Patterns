using Flyweight.flyweight;

namespace Flyweight.factory
{
    public class BookFactory
    {
        private Dictionary<string, BookFlyweight> bookPool = new Dictionary<string, BookFlyweight>();

        public BookFlyweight getBook(string title, string author, string isbn)
        {
            if(!bookPool.ContainsKey(isbn))
            {
                Console.WriteLine($"[Factory] สร้าง BookFlyweight ใหม่ สำหรับ ISBN: {isbn}");
                bookPool[isbn] = new BookFlyweight(title, author, isbn);
            }
            else
            {
                Console.WriteLine($"[Factory] ดึง BookFlyweight เดิมจาก Pool สำหรับ ISBN: {isbn}");
            }
            return bookPool[isbn];
        }

        public int PoolSize()
        {
            return bookPool.Count;
        }
    }
}