using Bridge.Implementation;

namespace Bridge.Abstraction
{
    public abstract class Accessory
    {
        private IGemstone gemstone;
        private string material;
        private string name;

        public Accessory(IGemstone gemstone, string material, string name)
        {
            this.gemstone = gemstone;
            this.material = material;
            this.name = name;
        }

        public virtual string getAccessoryInfo()
        {
            return $"Accessory: {name}\n" +
                   $"Material: {material}\n" +
                   $"Gemstone: {gemstone.getGemName()}\n" +
                   $"Stat Bonus: {gemstone.getStatBonus()}\n" +
                   $"Rarity: {gemstone.getRarity()}";
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