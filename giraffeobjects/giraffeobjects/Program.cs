using System;

namespace giraffeobjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);
            Book book2 = new Book("Lord of the Rings", "Tolkein", 800);
            Book book3 = new Book();

            Console.WriteLine(book2.author);

            Console.ReadLine();
        }
    }
}
