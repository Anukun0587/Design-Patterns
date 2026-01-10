namespace adapters.adaptee
{
    public class EnglishSource
    {
        private string text;

        public EnglishSource(string text)
        {
            this.text = text;
        }

        public string GetText()
        {
            return text;
        }

        public void SetText(string text)
        {
            this.text = text;
        }

        public string GetInfo()
        {
            return $"EnglishSource Text : {text}";
        }
    }
}