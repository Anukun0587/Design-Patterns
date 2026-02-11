using Mediator.mediator;

namespace Mediator.colleagues
{
    public abstract class GameUnit
    {
        protected IBattleMediator? mediator;
        private string name;
        private int hp;
        private int def;
        private int baseAtk;

        protected GameUnit(string name, int hp, int def, int baseAtk)
        {
            this.name = name;
            this.hp = hp;
            this.def = def;
            this.baseAtk = baseAtk;
        }

        public string getName()
        {
            return name;
        }

        public int getHp()
        {
            return hp;
        }

        public int getDef()
        {
            return def;
        }

        public int getBaseAtk()
        {
            return baseAtk;
        }

        public void setMediator(IBattleMediator mediator)
        {
            this.mediator = mediator;
        }

        public bool isDead()
        {
            return hp <= 0;
        }

        public void takeDamage(int damage)
        {
            hp -= damage;
            if (hp < 0)
            {
                hp = 0;
            }
        }
    }
}