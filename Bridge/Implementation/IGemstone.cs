namespace Bridge.Implementation
{
    public interface IGemstone
    {
        string GetGemName();
        void SetStatBonus(string statBonus);
        string GetStatBonus();
        void SetRarity(string rarity);
        string GetRarity();
    }
}