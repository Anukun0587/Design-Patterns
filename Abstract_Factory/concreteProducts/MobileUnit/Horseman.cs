using System;
using AbstractFactory.Products;

namespace AbstractFactory.ConcreteProducts.MobileUnits
{
    public class Horseman : MobileUnit
    {
        public override string Move()
        {
            return "Horseman Move!";
        }
        
        public override string Attack()
        {
            return "Horseman Attack!";
        }
    }
}