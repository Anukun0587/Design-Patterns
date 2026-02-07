namespace HerbInventory.Flyweight
{
    public class HerbType
    {
        private string name;
        private string category;
        private string medicinalEffect;

        public HerbType(string name, string category, string medicinalEffect)
        {
            this.name = name;
            this.category = category;
            this.medicinalEffect = medicinalEffect;
        }

        public string GetHerbTypeInfo()
        {
            return $" - สมุนไพร: {name}" +
                   $"\nประเภท: {category}" +
                   $"\nสรรพคุณ: {medicinalEffect}";
        }

        public void DisplayDetails(string name, int quantity, string quality)
        {
            Console.WriteLine($"\nชื่อสมุนไพร: {name}" +
                              $"\nจำนวน: {quantity} ชิ้น" +
                              $"\nคุณภาพ: {quality}" +
                              $"\n{GetHerbTypeInfo()}");
        }
    }
}