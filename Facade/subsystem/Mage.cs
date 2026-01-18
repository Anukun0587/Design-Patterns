namespace FacadePattern.subsystem
{
    public class Mage
    {
        private string _name;
        public Mage(string name) 
        {
            this._name = name;
            Introduce();
        }
        public void Introduce()
        {
            Console.WriteLine($"[System] Mage '{_name}' has joined the party.");
        }

        public void FireBall()
        {
            Console.WriteLine($"{_name}: ร่ายบอลไฟ (Fire Ball)");
        }

        public void FireExplosion()
        {
            Console.WriteLine($"{_name}: เกิดระเบิดไฟวงกว้าง (Fire Explosion!)");
        }

        public void AbyssalVoid()
        {
            Console.WriteLine($"{_name}: เปิดหลุมดำมหาเวท (Abyssal Void)");
        }

        public void Teleport(string location)
        {
            Console.WriteLine($"{_name}: วาร์ปทุกคนไปที่ {location}");
        }

        public void Rest()
        {
            Console.WriteLine($"{_name}: พักฟื้นพลังงาน (Rest)");
        }
    }
}