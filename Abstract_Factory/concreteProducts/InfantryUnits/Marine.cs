using System;
using AbstractFactory.Products;

namespace AbstractFactory.ConcreteProducts.InfantryUnits
{
    public class Marine : Infantry
    {
        public override string Move()
        {
            return "Marine Move!";
        }
        
        public override string Attack()
        {
            return "Marine Attack!";
        }
    }
}