using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritence_Exercise
{
    class Truck:Vehicle
    {
       public new void Drive()
       {
            Console.WriteLine("Drive method is in Truck Class");
       }
    }
}
