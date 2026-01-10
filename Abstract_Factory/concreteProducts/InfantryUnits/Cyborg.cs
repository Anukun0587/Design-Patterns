using System;
using AbstractFactory.Products;

namespace AbstractFactory.ConcreteProducts.InfantryUnits
{
    public class Cyborg : Infantry
    {
        public override string Move()
        {
            return "Cyborg Move!";
        }
        
        public override string Attack()
        {
            return "Cyborg Attack!";
        }
    }
}