namespace Bridge.Implementation
{
    public interface IGemstone
    {
        string getGemName();
        void setStatBonus(int statBonus);
        string getStatBonus();
        void setRarity(string rarity);
        string getRarity();
    }
}