using adapters.adaptee;

namespace adapters.adapter
{
    public class JP_Adapter : ThaiText
    {
        private JapaneseSource adaptee;

        public JP_Adapter(JapaneseSource adaptee)
        {
            this.adaptee = adaptee;
        }

        public string getThaiText()
            {
                string japaneseText = this.adaptee.GetText();
                return TranslateJapaneseToThai(japaneseText);
            }

            private string TranslateJapaneseToThai(string japaneseText)
            {
                return japaneseText switch
                {
                    "こんにちは" => "สวัสดี",
                    "ありがとう" => "ขอบคุณ",
                    "さようなら" => "ลาก่อน",
                    "おはよう" => "สวัสดีตอนเช้า",
                    "おやすみ" => "ราตรีสวัสดิ์",
                    _ => $"[แปลจากญี่ปุ่น: {japaneseText}]"
                };
            }
    }
}