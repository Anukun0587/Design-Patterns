using adapters.adapter;
using adapters.adaptee;

namespace adapters.service
{
    public class TranslationService
    {
        public string TranslateToThai(ThaiText adapter)
        {
            return adapter.getThaiText();
        }
    }
}