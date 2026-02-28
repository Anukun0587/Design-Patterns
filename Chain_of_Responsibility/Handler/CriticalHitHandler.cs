using DamageSystem.Models;

namespace DamageSystem.Handler
{
    public class CriticalHitHandler : DamageHandlerBase
    {
        private float CritMultiplier = 1.5f;

        protected override void Process(DamageContext ctx)
        {
            if (ctx.IsCritical)
            {
                ctx.FinalDamage *= CritMultiplier;
                Console.WriteLine($"[Crit] CRITICAL HIT! x{CritMultiplier} → FinalDamage = {ctx.FinalDamage:F1}");
            }
            else
            {
                Console.WriteLine("[Crit] No critical, skip.");
            }
        }
    }
}