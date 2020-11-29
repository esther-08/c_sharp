using System;

namespace giraffeinheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef();
            chef.MakeChicken();

            ItalianChef italianChef = new  ItalianChef();
            italianChef.MakeSpecialDish();

            Console.ReadLine();
        }
    }
}
