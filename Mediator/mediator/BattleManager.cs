using Mediator.colleagues;

namespace Mediator.mediator
{
    public class BattleManager : IBattleMediator
    {
        private Hero hero;
        private Monster monster;
        private BattleUI ui;

        public BattleManager(Hero hero, Monster monster, BattleUI battleUI)
        {
            this.hero = hero;
            this.monster = monster;
            this.ui = battleUI;

            hero.setMediator(this);
            monster.setMediator(this);
        }

        public bool IsBattleOver()
        {
            return hero.isDead() || monster.isDead();
        }

        public void Notify(GameUnit sender, string ev, int damage)
        {
            GameUnit target = (sender is Hero) ? monster : hero;
            ProcessDamage(sender, target, damage);
        }

        private void ProcessDamage(GameUnit attacker, GameUnit target, int rawDamage)
        {
            int finalDamage = rawDamage - target.getDef();
            if (finalDamage < 0) finalDamage = 0;

            ui.ShowDamageCalculation(
                    attacker.getName(),
                    target.getName(),
                    rawDamage,
                    target.getDef(),
                    finalDamage
            );

            if (finalDamage > 0)
            {
                target.takeDamage(finalDamage);
                ui.UpdateHP(target.getName(), target.getHp());
            }
            else
            {
                ui.ShowBlock(target.getName());
            }

            if (target.isDead())
            {
                ui.ShowVictory(attacker.getName());
            }
        }
    }
}
