namespace Mediator.colleagues
{
    public class Hero : GameUnit
    {
        public Hero(string name, int hp = 100, int def = 5, int atk = 20) : base(name, hp, def, atk)
        {
        }

        public void Attack()
        {
            Console.WriteLine($"\n[{getName()}] attacks with power {getBaseAtk()}!");
            mediator?.Notify(this, "Attack", getBaseAtk());
        }

        public void AttackCritical()
        {
            int critDmg = getBaseAtk() * 2;
            Console.WriteLine($"\n[{getName()}] CRITICAL STRIKE with power {critDmg}!");
            mediator?.Notify(this, "Attack", critDmg);
        }
    }
}