using System;

namespace giraffegetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Movies avengers = new Movies("The Avengers", "Joss Whedon", "PG-18");
            Movies shrek = new Movies("Shrek", "Adam Admson", "PG-13");

            Console.WriteLine(avengers.Rating);

            Console.ReadLine ();
        }
    }
}
