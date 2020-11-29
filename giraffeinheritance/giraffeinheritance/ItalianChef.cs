using System;
using System.Collections.Generic;
using System.Text;

namespace giraffeinheritance
{
    class ItalianChef : Chef
    {
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The chef makes chicken biryani");
        }
        public void MakePasta()
        {

        }

    }
}
