using DamageSystem.Models;

namespace DamageSystem.Handler
{
    public class BaseDamageHandler : DamageHandlerBase
    {
        protected override void Process(DamageContext ctx)
        {
            ctx.FinalDamage = ctx.WeaponDamage;
            Console.WriteLine($"[Base] WeaponDamage = {ctx.WeaponDamage}  →  FinalDamage = {ctx.FinalDamage}");
        }
    }
}