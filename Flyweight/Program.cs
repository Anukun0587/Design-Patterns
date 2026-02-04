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

            HerbItem ginseng1 = new HerbItem(3, "ธรรมดา", "ป่าเหนือ", "โสม", "ร้อน", "ฟื้นฟูและเพิ่มพูนลมปราณ", herbFactory);

            HerbItem pennywort1 = new HerbItem(5, "ดี", "หนองน้ำ", "ใบบัวบก", "เย็น", "รักษาอาการบาดเจ็บภายใน", herbFactory);

            Console.WriteLine("{ ginseng1, pennywort1 }\n");
            ginseng1.PrintDetails();
            pennywort1.PrintDetails();

            Console.WriteLine("\n{ show all herb types }");
            herbFactory.ListAllHerbTypes();
            HerbItem ginseng2 = new HerbItem(2, "ตำนาน", "ถ้ำมังกร", "โสม", "ร้อน", "ฟื้นฟูและเพิ่มพูนลมปราณ", herbFactory);

            HerbItem pennywort2 = new HerbItem(4, "พิเศษ", "ถ้ำน้ำตก", "ใบบัวบก", "เย็น", "รักษาอาการบาดเจ็บภายใน", herbFactory);

            Console.WriteLine("\n{ ginseng2, pennywort2 }");
            ginseng2.PrintDetails();
            pennywort2.PrintDetails();

            Console.WriteLine("\n{ show all herb types }");
            herbFactory.ListAllHerbTypes();
            HerbItem ginger = new HerbItem(1, "ตำนาน", "ภูเขาไฟ", "ขิง", "ร้อน", "ทำลายล้างความหนาวเย็นและพิษร้าย", herbFactory);

            Console.WriteLine("{ ginger }\n");
            ginger.PrintDetails();

            Console.WriteLine("\n{ show all herb types }");
            herbFactory.ListAllHerbTypes();
        }
    }
}