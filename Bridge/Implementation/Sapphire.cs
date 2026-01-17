namespace Bridge.Implementation
{
    public class Sapphire : IGemstone
    {
        private int mana;
        private string rarity;

        public Sapphire(int mana, string rarity)
        {
            this.mana = mana;
            this.rarity = rarity;
        }

        public string getGemName()
        {
            return "Sapphire";
        }

        public string getStatBonus()
        {
            return $"Mana + {mana}";
        }

        public void setStatBonus(int mana)
        {
            this.mana = mana;
        }

        public string getRarity()
        {
            return rarity;
        }

        public void setRarity(string rarity)
        {
            this.rarity = rarity;
        }
    }
}