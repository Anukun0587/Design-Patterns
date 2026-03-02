namespace Flyweight.flyweight
{
    public class BookFlyweight
    {
        private string title;
        private string author;
        private string isbn;

        public BookFlyweight(string title, string author, string isbn)
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
        }

        public string getTitle()
        {
            return title;
        }

        public string getAuthor()
        {
            return author;
        }

        public string getISBN()
        {
            return isbn;
        }

        public void PrintBorrowReceipt(string barcode, string borrowerName, string borrowerTel, string borrowDate, string dueDate, string status)
        {
            Console.WriteLine("\nใบยืมหนังสือ (BORROW RECEIPT)");
            Console.WriteLine($"ชื่อหนังสือ : {title}");
            Console.WriteLine($"ผู้แต่ง : {author}");
            Console.WriteLine($"ISBN : {isbn}");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Barcode : {barcode}");
            Console.WriteLine($"ชื่อผู้ยืม : {borrowerName}");
            Console.WriteLine($"เบอร์โทร : {borrowerTel}");
            Console.WriteLine($"สถานะ : {status}");
            Console.WriteLine($"วันที่ยืม : {borrowDate}");
            Console.WriteLine($"วันที่ต้องคืน : {dueDate}\n");
        }
    }
}