using System;

namespace giraffestaticattributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Song holiday = new Song("Holiday", "Green Day", 200);
            Console.WriteLine(Song.songCount);
            Song Kashmir = new Song("Kashmir", "Led Zeppelin", 150);
           
            Console.WriteLine(Song.songCount);
            
            Console.ReadLine();
        }
    }
}
