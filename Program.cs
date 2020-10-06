using System;

namespace Inheritence_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Car car = new Car();
             car.ModelName = "BMW";
             car.VehicleName = "Car";
             car.ModelYear = 2016;

             Console.WriteLine(car.VehicleName + "\t" + car.ModelName + "\t" + car.ModelYear);
             car.Drive();

             Truck truck = new Truck();
             truck.ModelName = "Scania";
             truck.VehicleName = "Truck";
             truck.ModelYear = 2010;

             Console.WriteLine(truck.VehicleName + "\t" + truck.ModelName + "\t" + truck.ModelYear);
             truck.Drive();

             Motorcycle motorcycle = new Motorcycle();
             motorcycle.ModelName = "Harley";
             motorcycle.VehicleName =  "Bike";
             motorcycle.ModelYear = 2013;

             Console.WriteLine(motorcycle.VehicleName + "\t" + motorcycle.ModelName + "\t" + motorcycle.ModelYear);
             motorcycle.Drive();*/


            IceCream icecream = new IceCream();
            icecream.Description();

            Chocolate chocolate = new Chocolate();
            chocolate.Description(); 
            
            Vanilla vanilla = new Vanilla();
            vanilla.Description();


            CarChild carchild = new CarChild("BMW");
            carchild.Colour("Green");
               
            

        }
    }
}
