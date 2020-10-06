using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritence_Exercise
{
    public class CarChild : CarBase, CarColour  // this class is for question 4
    {
        public CarChild(string carName) : base(carName) 
        {
            Console.WriteLine("This Is Child Car:" + carName);
        }

        public void Colour(string colour)
        {
            Console.WriteLine("This is color definition" );

        }


       

    }
}
