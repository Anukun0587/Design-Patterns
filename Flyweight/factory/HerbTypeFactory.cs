using HerbInventory.Flyweight;

namespace HerbInventory.Factory
{
    public class HerbTypeFactory
    {
        private Dictionary<string, HerbType> herbTypes = new Dictionary<string, HerbType>();

        public HerbType GetHerbType(string name, string category, string medicinalEffect)
        {
            if (!herbTypes.ContainsKey(name))
            {
                herbTypes[name] = new HerbType(name, category, medicinalEffect);
            }
            return herbTypes[name];
        }

        public void ListAllHerbTypes()
        {
            foreach (var herb in herbTypes.Values)
            {
                Console.WriteLine("-----");
                Console.WriteLine(herb.GetHerbTypeInfo());
            }
        }
    }
}