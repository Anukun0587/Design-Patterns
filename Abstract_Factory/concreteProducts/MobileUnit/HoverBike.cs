using System;
using AbstractFactory.Products;

namespace AbstractFactory.ConcreteProducts.MobileUnits
{
    public class HoverBike : MobileUnit
    {
        public override string Move()
        {
            return "HoverBike Move!";
        }
        
        public override string Attack()
        {
            return "HoverBike Attack!";
        }
    }
}