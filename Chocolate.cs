using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritence_Exercise
{
   public class Chocolate : IceCream
   {
        public new void Description()
        {
            Console.WriteLine("I love Chocolate");

        }

    }
}
