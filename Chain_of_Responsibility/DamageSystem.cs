using DamageSystem.Handler;
using DamageSystem.Models;

namespace DamageSystem
{
    public class DamageSystem
    {
        private readonly IDamageHandler firstHandler;

        public DamageSystem(IDamageHandler firstHandler)
        {
            this.firstHandler = firstHandler;
        }

        public float CalculateDamage(DamageContext ctx)
        {
            Console.WriteLine(new string('═', 50));
            Console.WriteLine($"{ctx.Attacker.Name} attacks {ctx.EnemyName}");
            Console.WriteLine(new string('─', 50));

            firstHandler.Handle(ctx);

            Console.WriteLine(new string('─', 50));
            string critTag = ctx.IsCritical ? "(CRITICAL!)" : "";
            Console.WriteLine($"Final Damage dealt to {ctx.EnemyName} = {ctx.FinalDamage:F1}{critTag}");
            Console.WriteLine(new string('═', 50));

            return ctx.FinalDamage;
        }
    }
}