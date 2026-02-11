namespace Mediator.colleagues
{
    public class BattleUI
    {
        public void ShowDamageCalculation(string attacker, string target, int rawDmg, int def, int finalDmg)
        {
            Console.WriteLine($"[UI] {attacker} -> {target}: {rawDmg} (Atk) - {def} (Def) = {finalDmg} Damage");
        }

        public void ShowBlock(string target)
        {
            Console.WriteLine($"[UI] >>> {target} BLOCKED the attack!");
        }

        public void UpdateHP(string target, int hp)
        {
            Console.WriteLine($"[UI] >>> {target} HP: {hp}");
        }

        public void ShowVictory(string winner)
        {
            Console.WriteLine($"\n[UI] ========== {winner} WINS! ==========");
        }
    }
}