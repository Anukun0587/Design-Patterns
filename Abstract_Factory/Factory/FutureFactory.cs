using AbstractFactory.Products;
using AbstractFactory.ConcreteProducts.InfantryUnits;
using AbstractFactory.ConcreteProducts.MobileUnits;
using AbstractFactory.ConcreteProducts.HeavyWeapons;

namespace AbstractFactory.Factory
{
    public class FutureFactory : ArmyFactory
    {
        public Infantry CreateInfantry()
        {
            return new Cyborg();
        }

        public MobileUnit CreateMobileUnit()
        {
            return new HoverBike();
        }

        public HeavyWeapon CreateHeavyWeapon()
        {
            return new TitanMech();
        }
    }
}