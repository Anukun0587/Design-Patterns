using System;
using Bridge.Abstraction;
using Bridge.Implementation;

namespace Bridge
{
    class Program
    {
        public static void Main(string[] args)
        {
            IGemstone ruby = new Ruby(500, "Rare");
            IGemstone sapphire = new Sapphire(100, "Epic");

            Accessory goldRing = new Ring(ruby, "Gold", "Warrior's Ring");
            Accessory silverNecklace = new Necklace(sapphire, "Silver", "Mage's Necklace");

            Console.WriteLine(goldRing.getAccessoryInfo());
            Console.WriteLine("\n" + silverNecklace.getAccessoryInfo());

            Console.WriteLine("\n=== Changing Gemstone ===\n");
            goldRing.Gemstone = sapphire;
            Console.WriteLine(goldRing.getAccessoryInfo());
            Console.WriteLine("\n=== Updating Stats ===\n");
            ruby.setStatBonus(1000);
            ruby.setRarity("Legendary");

            Accessory platinumRing = new Ring(ruby, "Platinum", "Champion's Ring");
            Console.WriteLine(platinumRing.getAccessoryInfo());
        }
    }
}