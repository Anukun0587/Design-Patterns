using System;
using Bridge.Abstraction;
using Bridge.Implementation;

namespace Bridge
{
    class Program
    {
        public static void Main(string[] args)
        {
            IGemstone ruby = new Ruby("+10 Strength", "Rare");
            IGemstone sapphire = new Sapphire("+15 Intelligence", "Epic");

            Amulet goldRing = new Ring(ruby, "Gold", "Warrior's Ring");
            Amulet silverNecklace = new Necklace(sapphire, "Silver", "Mage's Necklace");

            Console.WriteLine(goldRing.GetAmuletInfo());
            Console.WriteLine("\n" + silverNecklace.GetAmuletInfo());

            Console.WriteLine("\n=== Changing Gemstone ===\n");
            goldRing.Gemstone = sapphire;
            Console.WriteLine(goldRing.GetAmuletInfo());

            Console.WriteLine("\n=== Updating Stats ===\n");
            ruby.SetStatBonus("+20 Strength");
            ruby.SetRarity("Legendary");
            
            Amulet platinumRing = new Ring(ruby, "Platinum", "Champion's Ring");
            Console.WriteLine(platinumRing.GetAmuletInfo());
        }
    }
}