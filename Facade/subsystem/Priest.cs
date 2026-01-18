namespace FacadePattern.subsystem
{
    public class Priest
    {
        private string _name;
        public Priest(string name)
        {
            this._name = name;
            Introduce();
        }

        public void Introduce()
        {
            Console.WriteLine($"[System] Priest '{_name}' has joined the party.");
        }

        public void Heal()
        {
            Console.WriteLine($"{_name}: ฟื้นฟูพลังชีวิต (Heal)");
        }

        public void Purify()
        {
            Console.WriteLine($"{_name}: ล้างสถานะผิดปกติ (Purify)");
        }

        public void HolyBlessing()
        {
            Console.WriteLine($"{_name}: เพิ่มพลังโจมตีและป้องกัน (Holy Blessing)");
        }

        public void HolySanctuary()
        { 
            Console.WriteLine($"{_name}: กางเขตแดนศักดิ์สิทธิ์ [Holy Sanctuary]");
        }
        
        public void Resurrection()
        {
            Console.WriteLine($"{_name}: ร่ายมนต์ชุบชีวิต (Resurrection!)");
        }

        public void Rest()
        {
            Console.WriteLine($"{_name}: พักฟื้นพลังงาน (Rest)");
        }
    }
}