using AbstractFactory.Products;

namespace AbstractFactory.Factory
{
    public interface ArmyFactory
    {
        Infantry CreateInfantry();
        MobileUnit CreateMobileUnit();
        HeavyWeapon CreateHeavyWeapon();
    }
}