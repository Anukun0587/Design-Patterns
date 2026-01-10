namespace Prototypes.subSword
{
    public class LaserSword : Sword
    {
        private string batteryUnit;
        private string hiltMaterial;

        public LaserSword(LaserSword prototype) : base(prototype)
        {
            this.batteryUnit = prototype.batteryUnit;
            this.hiltMaterial = prototype.hiltMaterial;
        }

        public LaserSword(string damage, string durability, string batteryUnit, string hiltMaterial) : base(damage, durability)
        {
            this.batteryUnit = batteryUnit;
            this.hiltMaterial = hiltMaterial;
        }

        public override IPrototype Clone()
        {
            return new LaserSword(this);
        }

        public string BatteryUnit
        {
            get { return batteryUnit; }
            set { batteryUnit = value; }
        }

        public string HiltMaterial
        {
            get { return hiltMaterial; }
            set { hiltMaterial = value; }
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"BatteryUnit: {batteryUnit}, HiltMaterial: {hiltMaterial}");
        }
    }
}