using Mediator.colleagues;
using Mediator.mediator;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero player = new Hero("Anukul", hp: 80, def: 5);
            Monster golem = new Monster("Iron Golem", hp: 50, def: 15, atk: 18);
            BattleUI ui = new BattleUI();
            BattleManager manager = new BattleManager(player, golem, ui);

            Console.WriteLine("====== BATTLE START ======");
            Console.WriteLine($"{player.getName()} (HP:{player.getHp()}, Atk:{player.getBaseAtk()}, Def:{player.getDef()})");
            Console.WriteLine($"{golem.getName()} (HP:{golem.getHp()}, Atk:{golem.getBaseAtk()}, Def:{golem.getDef()})");

            // Turn 1
            player.Attack();        // 20 - 15 = 5 damage
            golem.Attack();         // 18 - 5 = 13 damage

            // Turn 2
            player.AttackCritical(); // 40 - 15 = 25 damage

            // Turn 3
            if (!manager.IsBattleOver())
            {
                golem.HeavyAttack();
                player.AttackCritical(); // 40 - 15 = 25 damage -> Golem ตาย
            }

            Console.WriteLine("\n====== BATTLE END ======");
            Console.ReadLine();
        }
    }
}