using System;
using AbstractFactory.Products;

namespace AbstractFactory.ConcreteProducts.HeavyWeapons
{
    public class Catapult : HeavyWeapon
    {
        public override string Move()
        {
            return "Catapult Move!";
        }
        
        public override string Attack()
        {
            return "Catapult Attack!";
        }
    }
}