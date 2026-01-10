using System;
using AbstractFactory.Factory;
using AbstractFactory.Products;

namespace AbstractFactory
{
    public class Client
    {
        public static void ShowArmyDetails(ArmyFactory factory)
        {
            Infantry infantry = factory.CreateInfantry();
            MobileUnit mobileUnit = factory.CreateMobileUnit();
            HeavyWeapon heavyWeapon = factory.CreateHeavyWeapon();
            
            Console.WriteLine(infantry.Move());
            Console.WriteLine(infantry.Attack());
            Console.WriteLine(mobileUnit.Move());
            Console.WriteLine(mobileUnit.Attack());
            Console.WriteLine(heavyWeapon.Move());
            Console.WriteLine(heavyWeapon.Attack());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Infantry factory");
            ArmyFactory medieval = new MedievalFactory();
            Client.ShowArmyDetails(medieval);
            Console.WriteLine("\n");

            Console.WriteLine("MobileUnit factory");
            ArmyFactory modern = new ModernFactory();
            Client.ShowArmyDetails(modern);
            Console.WriteLine("\n");

            Console.WriteLine("HeavyWeapon factory");
            ArmyFactory future = new FutureFactory();
            Client.ShowArmyDetails(future);
            Console.WriteLine("\n");

            Infantry infantry = modern.CreateInfantry();
            Console.WriteLine(infantry.Move());
            Console.WriteLine(infantry.Attack());
            Console.WriteLine("\n");

            ArmyFactory armyFactory = new ModernFactory();
            MobileUnit mobileUnit = armyFactory.CreateMobileUnit();
            Console.WriteLine(mobileUnit.Move());
            Console.WriteLine(mobileUnit.Attack());
        }
    }
}