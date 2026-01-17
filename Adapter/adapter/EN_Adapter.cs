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
            return this.adaptee.GetText().ToLower() switch
            {
                "hello" => "สวัสดี",
                "thank you" => "ขอบคุณ",
                _ => $"[แปลจากอังกฤษ: {this.adaptee.GetText().ToLower()}]"
            };
        }
    }
}