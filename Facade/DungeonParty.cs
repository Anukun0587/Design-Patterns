using FacadePattern.subsystem;

namespace FacadePattern
{
    public class DungeonParty
    {
        protected Knight knight;
        protected Mage mage;
        protected Priest priest;

        public DungeonParty(string kName, string mName, string pName)
        {
            Console.WriteLine("--- Gathering Party Members ---");
            this.knight = new Knight(kName);
            this.mage = new Mage(mName);
            this.priest = new Priest(pName);
            Console.WriteLine("-------------------------------\n");
        }

        public void EnterBossFight(string bossName)
        {
            Console.WriteLine($">>> [EVENT: Enter Boss Fight... {bossName}] <<<");
            priest.HolyBlessing();
            knight.IronDefense();
            knight.Taunt();
            mage.AbyssalVoid();
            priest.Heal();
            priest.Resurrection();
        }

        public void Escape(string safeLocation)
        {
            Console.WriteLine(">>> [EVENT: Emergency Escape] <<<");
            knight.IronDefense();
            priest.Purify();
            mage.Teleport(safeLocation);
        }

        public void Attack(string monsterType, int threatLevel)
        {
            Console.WriteLine($">>> [Action: Encounter with {monsterType} | Level: {threatLevel}] <<<");
            if (threatLevel <= 2) {
                knight.ShieldBash();
                mage.FireBall();
            } else if (threatLevel == 3) {
                knight.Taunt();
                mage.FireExplosion();
                priest.Heal();
            } else {
                priest.HolyBlessing();
                knight.IronDefense();
                knight.Taunt();
                mage.AbyssalVoid();
                priest.Heal();
                if (threatLevel > 5) {
                    priest.Resurrection();
                }
            }
        }

        public void RestParty()
        {
            Console.WriteLine(">>> [Action: Party Resting] <<<");
            priest.HolySanctuary();
            knight.Rest();
            mage.Rest();
            priest.Rest();
        }
    }
}