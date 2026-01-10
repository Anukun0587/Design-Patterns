using System;
using adapters.adaptee;
using adapters.adapter;

class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Original Sources:");
        JapaneseSource japaneseSource1 = new JapaneseSource("こんにちは");
        JapaneseSource japaneseSource2 = new JapaneseSource("ありがとう");
        Console.WriteLine(japaneseSource1.GetInfo());
        Console.WriteLine(japaneseSource2.GetInfo());

        EnglishSource englishSource1 = new EnglishSource("Hello");
        EnglishSource englishSource2 = new EnglishSource("Thank you");
        Console.WriteLine(englishSource1.GetInfo());
        Console.WriteLine(englishSource2.GetInfo());

        Console.WriteLine("\n" + new string('-', 50) + "\n");

        ThaiText jpAdapter1 = new JP_Adapter(japaneseSource1);
        ThaiText jpAdapter2 = new JP_Adapter(japaneseSource2);

        ThaiText enAdapter1 = new EN_Adapter(englishSource1);
        ThaiText enAdapter2 = new EN_Adapter(englishSource2);

        Console.WriteLine("Translated to Thai:");
        Console.WriteLine($"Japanese: {japaneseSource1.GetText()} -> {jpAdapter1.getThaiText()}");
        Console.WriteLine($"Japanese: {japaneseSource2.GetText()} -> {jpAdapter2.getThaiText()}");
        Console.WriteLine($"English: {englishSource1.GetText()} -> {enAdapter1.getThaiText()}");
        Console.WriteLine($"English: {englishSource2.GetText()} -> {enAdapter2.getThaiText()}");
    }
}