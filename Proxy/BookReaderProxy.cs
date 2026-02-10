namespace Proxy
{
    public class BookReaderProxy : IBookContent
    {
        private RealBookContent realBook;
        private bool isPremiumUser;

        public BookReaderProxy(string title, bool isPremium)
        {
            isPremiumUser = isPremium;
            realBook = new RealBookContent(title);
        }

        public void DisplayChapter(int chapterNumber)
        {
            if (chapterNumber <= 1 || isPremiumUser)
            {
                realBook.DisplayChapter(chapterNumber);
            }
            else
            {
                Console.WriteLine($"ไม่สามารถเข้าถึงได้: บทที่ {chapterNumber} สำหรับสมาชิกพรีเมียมเท่านั้น");
            }
        }

        public void GetChapterSummary()
        {
            realBook.GetChapterSummary();
        }

        public void DownloadChapter(int chapterNumber)
        {
            if (isPremiumUser)
            {
                realBook.DownloadChapter(chapterNumber);
            }
            else
            {
                Console.WriteLine($"อัพเกรดเป็นพรีเมียมเพื่อดาวน์โหลดเนื้อหา");
            }
        }
    }
}