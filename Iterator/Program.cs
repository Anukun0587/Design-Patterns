using System;
using Iterator.collection;
using Iterator.iterator;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Novel n1 = new Novel("The Little Prince", "Antoine de Saint-Exupéry", "Fantasy", "จบแล้ว", 50000);
            Novel n2 = new Novel("Harry Potter", "J.K. Rowling", "Fantasy", "จบแล้ว", 99000);
            Novel n3 = new Novel("Detective Conan", "Gosho Aoyama", "Mystery", "ยังไม่จบ", 45000);
            Novel n4 = new Novel("Romeo & Juliet", "William Shakespeare", "Romance", "จบแล้ว", 12000);
            Novel n5 = new Novel("The Lord of The Rings", "J.R.R. Tolkien", "Fantasy", "จบแล้ว", 85000);
            Novel n6 = new Novel("Otherside Picnic", "Iori Miyazawa", "Mystery", "ยังไม่จบ", 70000);
            Novel n7 = new Novel("Doraemon", "Fujiko F. Fujio", "Comedy", "จบแล้ว", 30000);

            NovelList myList = new NovelList();
            myList.addNovel(n1);
            myList.addNovel(n2);
            myList.addNovel(n3);
            myList.addNovel(n4);
            myList.addNovel(n5);
            myList.addNovel(n6);
            myList.addNovel(n7);

            Console.WriteLine("\n--- นิยายที่ 'จบแล้ว' (StatusIterator) ---");
            ShowNovel(myList.createStatusIterator("จบแล้ว"));

            Console.WriteLine("\n--- นิยายที่ 'ยังไม่จบ' (StatusIterator) ---");
            ShowNovel(myList.createStatusIterator("ยังไม่จบ"));

            Console.WriteLine("\n--- นิยายยอดนิยม (PopularityIterator - เรียงตามวิว) ---");
            ShowNovel(myList.createPopularityIterator());

            Console.WriteLine("\n--- นิยายหมวด Fantasy (CategoryIterator) ---");
            ShowNovel(myList.createCategoryIterator("Fantasy"));

            Console.WriteLine("\n--- นิยายหมวด Mystery (CategoryIterator) ---");
            ShowNovel(myList.createCategoryIterator("Mystery"));

        }

        public static void ShowNovel(INovelIterator iterator)
        {
            while (iterator.hasMore())
            {
                Console.WriteLine(iterator.getNext().ToString());
            }
        }
    }
}