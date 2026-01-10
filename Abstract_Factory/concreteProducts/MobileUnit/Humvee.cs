using System;
using AbstractFactory.Products;

namespace AbstractFactory.ConcreteProducts.MobileUnits
{
    public class Humvee : MobileUnit
    {
        public override string Move()
        {
            return "Humvee Move!";
        }
        
        public override string Attack()
        {
            return "Humvee Attack!";
        }
    }
}