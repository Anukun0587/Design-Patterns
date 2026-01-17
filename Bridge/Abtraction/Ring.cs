using Bridge.Implementation;

namespace Bridge.Abstraction
{
    public class Ring : Accessory
    {
        public Ring(IGemstone gemstone, string material, string name) 
            : base(gemstone, material, name)
        {
        }

        public override string getAccessoryInfo()
        {
            return "=== Ring ===\n" + base.getAccessoryInfo();
        }
    }
}