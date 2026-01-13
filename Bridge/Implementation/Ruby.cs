namespace Bridge.Implementation
{
    public class Ruby : IGemstone
    {
        private string statBonus;
        private string rarity;

        public Ruby(string statBonus, string rarity)
        {
            this.statBonus = statBonus;
            this.rarity = rarity;
        }

        public string GetGemName()
        {
            return "Ruby";
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