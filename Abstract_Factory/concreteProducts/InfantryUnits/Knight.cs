using System;
using AbstractFactory.Products;

namespace AbstractFactory.ConcreteProducts.InfantryUnits
{
    public class Knight : Infantry
    {
        public override string Move()
        {
            return "Knight Move!";
        }
        
        public override string Attack()
        {
            return "Knight Attack!";
        }
    }
}