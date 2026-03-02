using Flyweight.context;
using Flyweight.factory;

namespace HerbInventory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BookFactory factory = new BookFactory();

            Console.WriteLine("===== ระบบห้องสมุดดิจิทัล — Flyweight Pattern =====\n");

            // ── หนังสือ A : "Design Patterns" มี 3 Copy ที่ถูกยืมพร้อมกัน ──
            BookCopy copy1 = new BookCopy(
                barcode: "BC-001",
                borrowerName: "สมชาย ใจดี",
                borrowerTel: "081-111-1111",
                borrowDate: DateTime.Now.ToString("dd/MM/yyyy"),
                dueDate: DateTime.Now.AddDays(20).ToString("dd/MM/yyyy"),
                title: "Design Patterns",
                author: "Robert C. Martin",
                isbn: "9780132350884",
                factory: factory);

            BookCopy copy2 = new BookCopy(
                barcode: "BC-002",
                borrowerName: "มาลี รักอ่าน",
                borrowerTel: "082-222-2222",
                borrowDate: DateTime.Now.ToString("dd/MM/yyyy"),
                dueDate: DateTime.Now.AddDays(14).ToString("dd/MM/yyyy"),
                title: "Design Patterns",
                author: "Robert C. Martin",
                isbn: "9780132350884",
                factory: factory);

            BookCopy copy3 = new BookCopy(
                barcode: "BC-003",
                borrowerName: "วิทย์ อิอิ",
                borrowerTel: "083-333-3333",
                borrowDate: DateTime.Now.ToString("dd/MM/yyyy"),
                dueDate: DateTime.Now.AddDays(5).ToString("dd/MM/yyyy"),
                title: "Design Patterns",
                author: "Robert C. Martin",
                isbn: "9780132350884",
                factory: factory);

            // ── หนังสือ B : "Otherside Picnic" อีก ISBN ──
            BookCopy copy4 = new BookCopy(
                barcode: "BC-101",
                borrowerName: "นิรันดร์ อ่านเยอะ",
                borrowerTel: "084-444-4444",
                borrowDate: DateTime.Now.ToString("dd/MM/yyyy"),
                dueDate: DateTime.Now.AddDays(10).ToString("dd/MM/yyyy"),
                title: "Otherside Picnic",
                author: "Iori Miyazawa",
                isbn: "9780201633610",
                factory: factory);

            Console.WriteLine();

            copy1.printBorrowReceipt();
            copy2.printBorrowReceipt();
            copy3.printBorrowReceipt();
            copy4.printBorrowReceipt();

            copy1.returnBook();

            Console.WriteLine($"จำนวน BookFlyweight ใน Pool   : {factory.PoolSize()} object");
        }
    }
}