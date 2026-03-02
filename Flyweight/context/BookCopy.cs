using Flyweight.flyweight;
using Flyweight.factory;

namespace Flyweight.context
{
    public class BookCopy
    {
        private string barcode;
        private string borrowerName;
        private string borrowerTel;
        private string borrowDate;
        private string dueDate;
        private string status;
        private BookFlyweight book;

        public BookCopy(string barcode, string borrowerName, string borrowerTel,string borrowDate, string dueDate, string title, string author, string isbn , BookFactory factory)
        {
            this.barcode = barcode;
            this.borrowerName = borrowerName;
            this.borrowerTel = borrowerTel;
            this.borrowDate = borrowDate;
            this.dueDate = dueDate;
            this.status = "กำลังยืม";
            
            book = factory.getBook(title, author, isbn);
        }

        public void printBorrowReceipt()
        {
            book.PrintBorrowReceipt(barcode, borrowerName, borrowerTel, borrowDate, dueDate, status);
        }

        public void returnBook()
        {
            status = "คืนแล้ว";
            borrowerName = "-";
            Console.WriteLine($"[ระบบ] Barcode {barcode} ถูกคืนเรียบร้อยแล้ว\n");
        }

        public string getStatus()
        {
            return status;
        }

        public string getBarcode()
        {
            return barcode;
        }
    }
}