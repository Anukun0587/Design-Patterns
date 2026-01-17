namespace Bridge.Implementation
{
    public class Ruby : IGemstone
    {
        private int strength;
        private string rarity;

        public Ruby(int strength, string rarity)
        {
            this.strength = strength;
            this.rarity = rarity;
        }

        public string getGemName()
        {
            return "Ruby";
        }

        public string getStatBonus()
        {
            return $"Strength + {strength}";
        }

        public void setStatBonus(int strength)
        {
            this.strength = strength;
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