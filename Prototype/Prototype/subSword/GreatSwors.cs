namespace Prototypes.subSword
{
    public class GreatSword : Sword
    {
        private string weight;
        private string bladeWidth;

        public GreatSword(GreatSword prototype) : base(prototype)
        {
            this.weight = prototype.weight;
            this.bladeWidth = prototype.bladeWidth;
        }

        public GreatSword(string damage, string durability, string weight, string bladeWidth) : base(damage, durability)
        {
            this.weight = weight;
            this.bladeWidth = bladeWidth;
        }

        public override IPrototype Clone()
        {
            return new GreatSword(this);
        }

        public string Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public string BladeWidth
        {
            get { return bladeWidth; }
            set { bladeWidth = value; }
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Weight: {weight}, BladeWidth: {bladeWidth}");
        }
    }
}