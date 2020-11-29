using System;

namespace giraffearray
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[,] numberGrid =
            {
                {1,2 },
                {3,4 },
                {5,6 }
            };

                Console.WriteLine(numberGrid[2, 1]);

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);

            }
            
            

            Console.ReadLine();
        }
    }
}
