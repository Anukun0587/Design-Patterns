using HerbInventory.Factory;
using HerbInventory.Flyweight;

namespace HerbInventory.Context
{
    public class HerbItem
    {
        private int quantity;
        private string quality; 
        private string collectedLocation;
        private HerbType herbType;

        public HerbItem(int quantity, string quality, string collectedLocation, string herbName, string category, string medicinalEffect, HerbTypeFactory factory)
        {
            this.quantity = quantity;
            this.quality = quality;
            this.collectedLocation = collectedLocation;
            this.herbType = factory.GetHerbType(herbName, category, medicinalEffect);
        }

        public void PrintDetails()
        {
            herbType.DisplayDetails(quantity, quality, collectedLocation);
        }
    }
}