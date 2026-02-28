using DamageSystem.Models;

namespace DamageSystem.Handler
{
    public class ElementalHandler : DamageHandlerBase
    {
        private float WeaknessBonus     = 1.5f;  // แพ้ทาง   → +50%
        private float ResistancePenalty = 0.5f;  // ทนธาตุ   → -50%

        protected override void Process(DamageContext ctx)
        {
            if (ctx.Attacker.Element == ctx.EnemyWeakness)
            {
                ctx.FinalDamage *= WeaknessBonus;
                Console.WriteLine($"[Elemental] {ctx.Attacker.Element} hits weakness! x{WeaknessBonus}  →  FinalDamage = {ctx.FinalDamage:F1}");
            }
            else if (ctx.Attacker.Element == ctx.EnemyResistance)
            {
                ctx.FinalDamage *= ResistancePenalty;
                Console.WriteLine($"[Elemental] {ctx.Attacker.Element} resisted! x{ResistancePenalty}  →  FinalDamage = {ctx.FinalDamage:F1}");
            }
            else
            {
                Console.WriteLine($"[Elemental] {ctx.Attacker.Element} is neutral, skip.");
            }
        }
    }
}