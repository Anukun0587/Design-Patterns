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
            BookCategory offitial = new BookCategory("Offitial");
            
            ActionBook action = new ActionBook(5);
            ActionBook spiderman1 = new ActionBook(1);
            RomanceBook romance = new RomanceBook(3);
            FantasyBook fantasy = new FantasyBook(7);
            FantasyBook horry_potter1 = new FantasyBook(2);
            FantasyBook horry_potter2 = new FantasyBook(4);
            BookCategory horry_potter_offitial = new BookCategory("horry_potter_offitial");

            Console.WriteLine($"Action Book Count: {action.getCount()}");
            Console.WriteLine($"Romance Book Count: {romance.getCount()}");
            Console.WriteLine($"Fantasy Book Count: {fantasy.getCount()}");

            Console.WriteLine("\n"+new string('-', 50)+"\n");

            Console.WriteLine("Initial Structure");
            allBooks.add(fiction);
            allBooks.add(offitial);
            allBooks.getDetails();

            Console.WriteLine("\n"+new string('-', 50)+"\n");
            
            Console.WriteLine("After Adding Books");
            fiction.add(action);
            fiction.add(spiderman1);
            fiction.add(romance);
            fiction.add(fantasy);

            fiction.add(horry_potter1);
            fiction.add(horry_potter2);
            offitial.add(horry_potter_offitial);

            allBooks.getDetails();

            Console.WriteLine($"Total of all books: {allBooks.getCount()}");
        }
    }
}