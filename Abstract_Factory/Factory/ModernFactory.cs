using AbstractFactory.Products;
using AbstractFactory.ConcreteProducts.InfantryUnits;
using AbstractFactory.ConcreteProducts.MobileUnits;
using AbstractFactory.ConcreteProducts.HeavyWeapons;

namespace AbstractFactory.Factory
{
    public class ModernFactory : ArmyFactory
    {
        public Infantry CreateInfantry()
        {
            return new Marine();
        }

        public MobileUnit CreateMobileUnit()
        {
            return new Humvee();
        }

        public HeavyWeapon CreateHeavyWeapon()
        {
            return new Tank();
        }
    }
}