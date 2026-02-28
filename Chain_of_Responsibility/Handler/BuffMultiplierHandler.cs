using DamageSystem.Models;

namespace DamageSystem.Handler
{
    public class BuffMultiplierHandler : DamageHandlerBase
    {
        protected override void Process(DamageContext ctx)
        {
            if (ctx.Attacker.HasBuff)
            {
                ctx.FinalDamage *= ctx.Attacker.BuffMultiplier;
                Console.WriteLine($"[Buff] x{ctx.Attacker.BuffMultiplier} (Buff active)  →  FinalDamage = {ctx.FinalDamage:F1}");
            }
            else
            {
                Console.WriteLine("[Buff] No buff, skip.");
            }
        }
    }
}