using System;
using AbstractFactory.Products;

namespace AbstractFactory.ConcreteProducts.HeavyWeapons
{
    public class Tank : HeavyWeapon
    {
        public override string Move()
        {
            return "Tank Move!";
        }
        
        public override string Attack()
        {
            return "Tank Attack!";
        }
    }
}