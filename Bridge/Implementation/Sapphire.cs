namespace Bridge.Implementation
{
    public class Sapphire : IGemstone
    {
        private string statBonus;
        private string rarity;

        public Sapphire(string statBonus, string rarity)
        {
            this.statBonus = statBonus;
            this.rarity = rarity;
        }

        public string GetGemName()
        {
            return "Sapphire";
        }

        public string GetStatBonus()
        {
            return statBonus;
        }

        public void SetStatBonus(string statBonus)
        {
            this.statBonus = statBonus;
        }

        public string GetRarity()
        {
            return rarity;
        }

        public void SetRarity(string rarity)
        {
            this.rarity = rarity;
        }
    }
}