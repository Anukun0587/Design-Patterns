using HerbInventory.Context;
using HerbInventory.Factory;

namespace HerbInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{ Herb Inventory }\n");

            HerbTypeFactory herbFactory = new HerbTypeFactory();

            HerbItem ginseng1 = new HerbItem("โสม 100 ปี", 3, "ธรรมดา", "โสม", "ร้อน", "ฟื้นฟูและเพิ่มพูนลมปราณ", herbFactory);
            HerbItem pennywort1 = new HerbItem("ใบบัวบกขาว", 5, "ดี", "ใบบัวบก", "เย็น", "รักษาอาการบาดเจ็บภายใน", herbFactory);

            Console.WriteLine("{ ginseng1, pennywort1 }\n");
            ginseng1.PrintDetails();
            pennywort1.PrintDetails();

            Console.WriteLine("\n{ show all herb types }");
            herbFactory.ListAllHerbTypes();

            HerbItem ginseng2 = new HerbItem("โสม 1000 ปี", 2, "ตำนาน", "โสม", "ร้อน", "ฟื้นฟูและเพิ่มพูนลมปราณ", herbFactory);
            HerbItem pennywort2 = new HerbItem("ใบบัวบกแดง", 4, "พิเศษ", "ใบบัวบก", "เย็น", "รักษาอาการบาดเจ็บภายใน", herbFactory);

            Console.WriteLine("\n{ ginseng2, pennywort2 }");
            ginseng2.PrintDetails();
            pennywort2.PrintDetails();

            Console.WriteLine("\n{ show all herb types }");
            herbFactory.ListAllHerbTypes();
            HerbItem ginger = new HerbItem("ขิงตากแห้ง", 1, "ธรรมดา", "ขิง", "ร้อน", "ทำลายล้างความหนาวเย็นและพิษร้าย", herbFactory);

            Console.WriteLine("{ ginger }\n");
            ginger.PrintDetails();

            Console.WriteLine("\n{ show all herb types }");
            herbFactory.ListAllHerbTypes();
        }
    }
}