using Bridge.Implementation;

namespace Bridge.Abstraction
{
    public class Necklace : Amulet
    {
        public Necklace(IGemstone gemstone, string material, string name) 
            : base(gemstone, material, name)
        {
        }

        public override string GetAmuletInfo()
        {
            return "=== Necklace ===\n" + base.GetAmuletInfo();
        }
    }
}