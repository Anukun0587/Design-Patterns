namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DungeonParty myParty = new DungeonParty("Arthur", "Merlin", "Aqua");

            Console.WriteLine("entering dungeon...");

            Console.WriteLine("\n encountered enemies! Goblin King appears!");
            myParty.Attack("Goblin King", 3);

            Console.WriteLine("\n deeper into the dungeon... Dragon Lord appears!");
            myParty.Attack("Dragon Lord", 7);

            Console.WriteLine("\n after intense battles, the party needs to rest.");
            myParty.RestParty();

            Console.WriteLine("\n approaching the final boss...");
            myParty.EnterBossFight("The Void Architect");

            Console.WriteLine("\n Time to escape!");
            myParty.EmergencyEscape("Safe Haven");
        }
    }
}