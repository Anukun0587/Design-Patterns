using DamageSystem.Handler;
using DamageSystem.Models;

namespace DamageSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseDamageHandler     = new BaseDamageHandler();
            var buffMultiplierHandler = new BuffMultiplierHandler();
            var elementalHandler      = new ElementalHandler();
            var defenseMitigation     = new DefenseMitigationHandler();
            var criticalHitHandler    = new CriticalHitHandler();

            baseDamageHandler
                .SetNext(buffMultiplierHandler)
                .SetNext(elementalHandler)
                .SetNext(defenseMitigation)
                .SetNext(criticalHitHandler);

            var damageSystem = new DamageSystem(baseDamageHandler);

            //  Case 1: ตีโดนจุดอ่อน + มี Buff + ติด Crit
            Console.WriteLine("\n Case 1: Fire hits Ice Golem's weakness + Buff + Critical");
            var hero = new Attacker { Name = "SUKSAN HERO", HasBuff = true, BuffMultiplier = 1.5f, Element = "Fire" };
            var ctx1 = new DamageContext
            {
                Attacker        = hero,
                EnemyName       = "Ice Golem",
                EnemyWeakness   = "Fire",
                EnemyResistance = "Ice",
                EnemyDefense    = 20,
                WeaponDamage    = 100,
                IsCritical      = true
            };
            damageSystem.CalculateDamage(ctx1);

            // Case 2: โดนทน + ไม่มี Buff + ไม่ติด Crit
            Console.WriteLine("\n Case 2: Fire hits Fire Drake (resistant) + No Buff + No Crit");
            var mage = new Attacker { Name = "MAGE", HasBuff = false, Element = "Fire" };
            var ctx2 = new DamageContext
            {
                Attacker        = mage,
                EnemyName       = "Fire Drake",
                EnemyWeakness   = "Ice",
                EnemyResistance = "Fire",
                EnemyDefense    = 10,
                WeaponDamage    = 80,
                IsCritical      = false
            };
            damageSystem.CalculateDamage(ctx2);

            //  Case 3: Neutral Element + No Buff + ติด Crit
            Console.WriteLine("\n Case 3: Earth hits Skeleton (neutral) + Critical");
            var warrior = new Attacker { Name = "WARRIOR", HasBuff = false, Element = "Earth" };
            var ctx3 = new DamageContext
            {
                Attacker        = warrior,
                EnemyName       = "Skeleton",
                EnemyWeakness   = "Fire",
                EnemyResistance = "Ice",
                EnemyDefense    = 5,
                WeaponDamage    = 60,
                IsCritical      = true
            };
            damageSystem.CalculateDamage(ctx3);
        }
    }
}