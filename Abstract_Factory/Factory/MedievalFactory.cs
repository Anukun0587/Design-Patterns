using AbstractFactory.Products;
using AbstractFactory.ConcreteProducts.InfantryUnits;
using AbstractFactory.ConcreteProducts.MobileUnits;
using AbstractFactory.ConcreteProducts.HeavyWeapons;

namespace AbstractFactory.Factory
{
    public class MedievalFactory : ArmyFactory
    {
        public Infantry CreateInfantry()
        {
            return new Knight();
        }

        public MobileUnit CreateMobileUnit()
        {
            return new Horseman();
        }

        public HeavyWeapon CreateHeavyWeapon()
        {
            return new Catapult();
        }
    }
}