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

        public string GetDescription()
        {
            return $" - สมุนไพร: {name}" +
                   $"\nประเภท: {category}" +
                   $"\nสรรพคุณ: {medicinalEffect}";
        }

        public void DisplayDetails(int quantity, string quality, string collectedLocation)
        {
            Console.WriteLine($"\nจำนวน: {quantity} ชิ้น" +
                              $"\nคุณภาพ: {quality}" +
                              $"\nเก็บจาก: {collectedLocation}" +
                              $"\n{GetDescription()}");
        }
    }
}