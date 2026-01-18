namespace FacadePattern.subsystem
{
    public class Knight
    {
        private string _name;
        public Knight(string name) 
        {
            this._name = name;
            Introduce();
        }
        
        public void Introduce()
        {
            Console.WriteLine($"[System] Knight '{_name}' has joined the party.");
        }

        public void Taunt()
        {
            Console.WriteLine($"{_name}: ตะโกนยั่วยุศัตรู (Taunt!)");
        }

        public void ShieldBash()
        {
            Console.WriteLine($"{_name}: กระแทกโล่ใส่ศัตรู (Shield Bash)");
        }

        public void IronDefense()
        {
            Console.WriteLine($"{_name}: เปิดโหมดตั้งรับสมบูรณ์แบบ (Iron Defense)");
        }

        public void Rest()
        {
            Console.WriteLine($"{_name}: พักฟื้นพลังงาน (Rest)");
        }
    }
}