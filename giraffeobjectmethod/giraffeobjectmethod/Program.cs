using System;

namespace giraffeobjectmethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Jim", "Business", 4.2);
            Student student2 = new Student("Ron", "Art", 3.1);

            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());

            Console.ReadLine();
        }
    }
}
