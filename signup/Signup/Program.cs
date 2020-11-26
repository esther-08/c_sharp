using System;

namespace Signup
{
    class Program
    {
        static void Main(string[] args)
        {
            int userAge;
            Console.WriteLine("Please enter your age: ");
            userAge = Convert.ToInt32(Console.ReadLine());
            if (userAge < 0 || userAge > 100)
            {
                Console.WriteLine("Invalid age. ");
                Console.WriteLine("Age must be between 0 and 100. ");

            }
            else if (userAge < 18)
                Console.WriteLine("Sorry you are underage");
            else if (userAge < 20)
                Console.WriteLine("You need parental guidance");
            
            else
                {
                    Console.WriteLine("Congratulations! ");
                    Console.WriteLine("You may signup for the event. ");
                    Console.ReadLine();
                }


            }
        }
    }

