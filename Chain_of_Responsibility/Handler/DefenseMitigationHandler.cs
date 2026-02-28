using DamageSystem.Models;

namespace DamageSystem.Handler
{
    public class DefenseMitigationHandler : DamageHandlerBase
    {
        protected override void Process(DamageContext ctx)
        {
            float mitigated = MathF.Max(0, ctx.FinalDamage - ctx.EnemyDefense);
            Console.WriteLine($"[Defense]  FinalDamage({ctx.FinalDamage:F1}) - Defense({ctx.EnemyDefense}) = {mitigated:F1}");
            ctx.FinalDamage = mitigated;
        }
    }
}