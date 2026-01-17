using Composite.BookSystem;
using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- BOOK ----");
            
            BookCategory allBooks = new BookCategory("All Books");
            BookCategory fiction = new BookCategory("Fiction");
            
            ActionBook action = new ActionBook();
            RomanceBook romance = new RomanceBook();
            FantasyBook fantasy = new FantasyBook();
            
            Console.WriteLine("Initial Structure");
            allBooks.add(fiction);
            allBooks.getDetails();

            Console.WriteLine("\n"+new string('-', 50)+"\n");
            
            Console.WriteLine("After Adding Books");
            fiction.add(action);
            fiction.add(romance);
            fiction.add(fantasy);
            allBooks.getDetails();
        }
    }
}