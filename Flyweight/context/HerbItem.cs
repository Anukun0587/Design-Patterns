using HerbInventory.Factory;
using HerbInventory.Flyweight;

namespace HerbInventory.Context
{
    public class HerbItem
    {
        private string name;
        private int quantity;
        private string quality; 
        private HerbType herbType;

        public HerbItem(string name, int quantity, string quality, string herbName, string category, string medicinalEffect, HerbTypeFactory factory)
        {
            this.name = name;
            this.quantity = quantity;
            this.quality = quality;
            this.herbType = factory.GetHerbType(herbName, category, medicinalEffect);
        }

        public void PrintDetails()
        {
            herbType.DisplayDetails(name, quantity, quality);
        }
    }
}