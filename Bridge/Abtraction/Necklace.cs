using Bridge.Implementation;

namespace Bridge.Abstraction
{
    public class Necklace : Accessory
    {
        public Necklace(IGemstone gemstone, string material, string name) 
            : base(gemstone, material, name)
        {
        }

        public override string getAccessoryInfo()
        {
            return "=== Necklace ===\n" + base.getAccessoryInfo();
        }
    }
}