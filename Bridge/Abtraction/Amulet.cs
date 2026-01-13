using Bridge.Implementation;

namespace Bridge.Abstraction
{
    public abstract class Amulet
    {
        private IGemstone gemstone;
        private string material;
        private string name;

        public Amulet(IGemstone gemstone, string material, string name)
        {
            this.gemstone = gemstone;
            this.material = material;
            this.name = name;
        }

        public virtual string GetAmuletInfo()
        {
            return $"Amulet: {name}\n" +
                   $"Material: {material}\n" +
                   $"Gemstone: {gemstone.GetGemName()}\n" +
                   $"Stat Bonus: {gemstone.GetStatBonus()}\n" +
                   $"Rarity: {gemstone.GetRarity()}";
        }

        public IGemstone Gemstone
        {
            get { return gemstone; }
            set { gemstone = value; }
        }

        public string Material
        {
            get { return material; }
            set { material = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}