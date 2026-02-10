namespace Proxy
{
    public class RealBookContent : IBookContent
    {
        private string bookTitle;

        public RealBookContent(string title)
        {
            bookTitle = title;
            Console.WriteLine($"กำลังโหลดข้อมูลหนังสือ '{bookTitle}'...");
        }

        public void DisplayChapter(int chapterNumber)
        {
            Console.WriteLine($"กำลังอ่าน: {bookTitle} - บทที่ {chapterNumber}");
        }

        public void GetChapterSummary()
        {
            Console.WriteLine($"เรื่องย่อของหนังสือ '{bookTitle}'");
        }

        public void DownloadChapter(int chapterNumber)
        {
            Console.WriteLine($"ดาวน์โหลดสำเร็จ! บทที่ {chapterNumber} ของ '{bookTitle}' พร้อมอ่านออฟไลน์แล้ว");
        }
    }
}