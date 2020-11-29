using System;

namespace IfStatement
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isMale = true;
            bool isTall = false;

            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male");

            }
            else if(isMale && !isTall)
            {
                Console.WriteLine("You are a short man");
            } 
            else if (!isMale && isTall) 
            {
                Console.WriteLine("You are not a man but tall");
            }
            else
            {
                Console.WriteLine("You are not male and not tall");
            }
            
            Console.ReadLine();
        }
    }
}
