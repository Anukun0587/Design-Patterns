using adapters.service;
using adapters.adapter;
using adapters.adaptee;

class Program
{
    static void Main(string[] args)
    {
        TranslationService translationService = new TranslationService();

        Console.WriteLine("=== Using TranslateToThai ===\n");
        string result1 = translationService.TranslateToThai(new EN_Adapter(new EnglishSource("Hello")));
        Console.WriteLine("TranslateToThai hello : "+result1);
        
        string result2 = translationService.TranslateToThai(new JP_Adapter(new JapaneseSource("こんにちは")));
        Console.WriteLine("TranslateToThai こんにちは : "+result2);
    }
}