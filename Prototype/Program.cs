using System;
using Prototypes;
using Prototypes.subSword;

namespace Prototype
{
    class Program
    {
        static void Main(String[] arge)
        {
            Sword sword = new Sword("sword-damage", "sword-durability");
            GreatSword greatSword = new GreatSword("greatsword-damage", "greatsword-durability", "greatsword-weight", "greatsword-bladeWidth");
            LaserSword laserSword = new LaserSword("lasersword-damage", "lasersword-durability", "lasersword-batteryUnit", "lasersword-hiltMaterial");

            Sword clonedSword = (Sword)sword.Clone();
            clonedSword.Damage = "cloned-sword-damage";

            GreatSword clonedGreatSword = (GreatSword)greatSword.Clone();
            clonedGreatSword.Weight = "cloned-greatsword-weight";

            LaserSword clonedLaserSword = (LaserSword)laserSword.Clone();
            clonedLaserSword.HiltMaterial = "cloned-lasersword-hiltMaterial";

            Console.WriteLine("Prototype Sword");
            sword.DisplayInfo();
            Console.WriteLine("Cloned Sword");
            clonedSword.DisplayInfo();

            Console.WriteLine("\n" + new string('-', 50) + "\n");

            Console.WriteLine("Prototype GreatSword");
            greatSword.DisplayInfo();
            Console.WriteLine("Cloned GreatSword");
            clonedGreatSword.DisplayInfo();

            Console.WriteLine("\n" + new string('-', 50) + "\n");

            Console.WriteLine("Prototype LaserSword");
            laserSword.DisplayInfo();
            Console.WriteLine("Cloned LaserSword");
            clonedLaserSword.DisplayInfo();
        }
    }
}