namespace DamageSystem.Models
{
    public class Attacker
    {
        public string? Name           { get; set; }
        public bool   HasBuff        { get; set; }
        public float  BuffMultiplier { get; set; } = 1.5f;
        public string? Element        { get; set; }
    }
}