using Strategy.context;
using Strategy.strategy;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sortedData = { 2, 5, 8, 12, 16, 23, 38, 45, 56, 72, 91 };

            Searcher searcher = new Searcher();

            LinearSearch linearSearch = new LinearSearch();
            BinarySearch binarySearch = new BinarySearch();
            JumpSearch jumpSearch = new JumpSearch();

            Console.WriteLine($"ข้อมูล : [{string.Join(", ", sortedData)}] \n");

            searcher.setData(sortedData);

            Console.WriteLine("เริ่มด้วย Linear Search ค้นหา : 23");
            searcher.setStrategy(linearSearch);
            searcher.search(23);

            Console.WriteLine("เปลี่ยนเป็น Binary Search ค้นหา : 45");
            searcher.setStrategy(binarySearch);
            searcher.search(45);

            Console.WriteLine("เปลี่ยนเป็น Jump Search ค้นหา : 72");
            searcher.setStrategy(jumpSearch);
            searcher.search(72);

            Console.WriteLine("── ทดสอบกรณีไม่พบ Binary Search ค้นหา : 999──");
            searcher.setStrategy(binarySearch);
            searcher.search(999);
        }
    }
}