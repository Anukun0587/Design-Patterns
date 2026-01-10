namespace adapters.adaptee
{
    public class JapaneseSource
    {
        private string text;

        public JapaneseSource(string text)
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
            return $"JapaneseSource Text : {text}";
        }
    }
}