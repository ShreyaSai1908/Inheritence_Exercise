using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritence_Exercise
{
    class Motorcycle: Vehicle
    {
        public new void Drive()
        {
            Console.WriteLine("Drive method is in Motorcycle Class");
        }
    }
}
