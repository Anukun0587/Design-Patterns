namespace DamageSystem.Models
{
    public class DamageContext
    {
        public Attacker Attacker        { get; set; }
        public string?   EnemyName       { get; set; }
        public string?   EnemyWeakness   { get; set; }   // ธาตุที่ศัตรูแพ้
        public string?   EnemyResistance { get; set; }   // ธาตุที่ศัตรูทน
        public int      EnemyDefense    { get; set; }
        public int      WeaponDamage    { get; set; } 
        public float    FinalDamage     { get; set; }
        public bool     IsCritical      { get; set; }
    }
}