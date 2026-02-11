namespace Mediator.colleagues
{
    public class Monster : GameUnit
    {
        public Monster(string name, int hp = 100, int def = 10, int atk = 15) : base(name, hp, def, atk)
        {
        }

        public void Attack()
        {
            Console.WriteLine($"\n[{getName()}] strikes back with power {getBaseAtk()}!");
            mediator?.Notify(this, "Attack", getBaseAtk());
        }

        public void HeavyAttack()
        {
            int heavyDmg = (int)(getBaseAtk() * 1.5);
            Console.WriteLine($"\n[{getName()}] uses HEAVY SLAM with power {heavyDmg}!");
            mediator?.Notify(this, "Attack", heavyDmg);
        }
    }
}