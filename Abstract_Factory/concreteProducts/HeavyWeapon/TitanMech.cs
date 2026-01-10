using System;
using AbstractFactory.Products;

namespace AbstractFactory.ConcreteProducts.HeavyWeapons
{
    public class TitanMech : HeavyWeapon
    {
        public override string Move()
        {
            return "TitanMech Move!";
        }
        
        public override string Attack()
        {
            return "TitanMech Attack!";
        }
    }
}