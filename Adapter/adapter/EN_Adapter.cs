using adapters.adaptee;

namespace adapters.adapter
{
    public class EN_Adapter : ThaiText
    {
        private EnglishSource adaptee;

        public EN_Adapter(EnglishSource adaptee)
        {
            this.adaptee = adaptee;
        }

        public string getThaiText()
        {
            string englishText = this.adaptee.GetText();
            return TranslateEnglishToThai(englishText);
        }

        private string TranslateEnglishToThai(string englishText)
        {
            // Simple translation mapping
            return englishText.ToLower() switch
            {
                "hello" => "สวัสดี",
                "thank you" => "ขอบคุณ",
                "goodbye" => "ลาก่อน",
                "good morning" => "สวัสดีตอนเช้า",
                "good night" => "ราตรีสวัสดิ์",
                "welcome" => "ยินดีต้อนรับ",
                _ => $"[แปลจากอังกฤษ: {englishText}]"
            };
        }
    }
}