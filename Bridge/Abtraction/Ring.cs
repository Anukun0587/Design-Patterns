using Bridge.Implementation;

namespace Bridge.Abstraction
{
    public class Ring : Amulet
    {
        public Ring(IGemstone gemstone, string material, string name) 
            : base(gemstone, material, name)
        {
        }

        public override string GetAmuletInfo()
        {
            return "=== Ring ===\n" + base.GetAmuletInfo();
        }
    }
}