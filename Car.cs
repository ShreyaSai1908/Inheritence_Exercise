using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritence_Exercise
{
    class Car:Vehicle //this child class is for question 1
    {
        
        public new void Drive()
        {
            Console.WriteLine("Drive method is in Car Class");
        } 

    }
}
